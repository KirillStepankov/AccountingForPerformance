using AccountingForPerformance.Entities;
using AccountingForPerformance.LogicalEntities;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AppExcel = Microsoft.Office.Interop.Excel.Application;

namespace AccountingForPerformance.Models
{
    public class ExportExcel
    {
        private AppExcel excel;
        private Workbook workbook;
        private Worksheet currentWorksheet;


        public ExportExcel()
        {
            excel = new AppExcel();
        }

        public void Export(List<Performance> performances)
        {
            List<AcademicYear> academicYears = new List<AcademicYear>();
            foreach(Performance performance in performances)
            {

                if (academicYears.Any(ay => ay == performance.AcademicYear))
                    continue;
                academicYears.Add(performance.AcademicYear);
            }

            foreach (AcademicYear ay in academicYears)
            {
                workbook = excel.Workbooks.Add();
                OuputExamYear(performances.Where(p => p.AcademicYear.Id == ay.Id).ToList());
            }

            excel.Visible = true;
        }

        private void OuputExamYear(List<Performance> performances)
        {
            List<SchoolClass> classes = new List<SchoolClass>();
            List<SchoolSubject> subjects = new List<SchoolSubject>();
            List<EducationalInstitution> educationalInstitutions = new List<EducationalInstitution>();
            foreach (Performance performance in performances)
            {

                if (!classes.Any(c => c.Id == performance.SchoolClass.Id))
                    classes.Add(performance.SchoolClass);
                if (!subjects.Any(s => s.Id == performance.SchoolSubject.Id))
                    subjects.Add(performance.SchoolSubject);
                if (!educationalInstitutions.Any(ei => ei.Id == performance.EducationalInstitution.Id))
                    educationalInstitutions.Add(performance.EducationalInstitution);
            }

            foreach (SchoolClass currentClass in classes)
            {
                currentWorksheet = workbook.Worksheets.Add();
                currentWorksheet.Name = currentClass.Name;
                int numRow = 13;
                OutputHeaderExamYear(ref currentWorksheet, performances.FirstOrDefault()?.AcademicYear.Name);


                List<Performance> performancesByClass = performances.Where(p => p.SchoolClass.Id == currentClass.Id).ToList();
                subjects.Clear();
                foreach (Performance performance in performancesByClass)
                {
                    if (!subjects.Any(s => s.Id == performance.SchoolSubject.Id))
                        subjects.Add(performance.SchoolSubject);
                }


                int numSubject = 1;
                foreach (SchoolSubject subject in subjects)
                {
                    List<Performance> performancesBySubject = performancesByClass.Where(p => p.SchoolSubject.Id == subject.Id).ToList();

                    OutputYearForSubject(performancesBySubject.Where(p => p.TypeAssessment.Id == 5).ToList(), numRow, numSubject, subject.Name);    // выбираем экзамены
                    OutputExamForSubject(performancesBySubject.Where(p => p.TypeAssessment.Id == 6).ToList(), numRow, numSubject, subject.Name);    // выбираем экзамены

                    currentWorksheet.Range["A" + numRow, "Y" + numRow].HorizontalAlignment = XlVAlign.xlVAlignCenter;
                    currentWorksheet.Range["A" + numRow, "Y" + numRow].VerticalAlignment = XlVAlign.xlVAlignCenter;
                    currentWorksheet.Range["A" + numRow, "Y" + numRow].WrapText = true;
                    currentWorksheet.Range["A" + numRow, "Y" + numRow].Interior.Color = XlRgbColor.rgbAqua;

                    numRow++;

                    int numSchoool = 1;
                    foreach(EducationalInstitution school in educationalInstitutions)
                    {
                        Performance yearPerformance = performancesBySubject.Where(p => p.EducationalInstitution.Id == school.Id && p.TypeAssessment.Id == 5).FirstOrDefault();
                        Performance examPerformance = performancesBySubject.Where(p => p.EducationalInstitution.Id == school.Id && p.TypeAssessment.Id == 6).FirstOrDefault();
                        OutputYearForSchool(yearPerformance, numRow, numSchoool);
                        OutputExamForSchool(examPerformance, numRow, numSchoool, school.Name);

                        numRow++;
                        numSchoool++;
                    }
                    numSubject++;
                }
            }
           
            currentWorksheet.Visible = XlSheetVisibility.xlSheetVisible;
        }
        private void OutputExamForSubject(List<Performance> performances, int numRow, int numSubject = 1, string nameSubject = "")
        {
            currentWorksheet.Cells[numRow, 1] = numSubject;
            currentWorksheet.Cells[numRow, 2] = nameSubject;
            currentWorksheet.Cells[numRow, 3] = performances.Sum(p => p.CountTotal);
            currentWorksheet.Cells[numRow, 4] = performances.Sum(p => p.CountTotal);

            currentWorksheet.Cells[numRow, "E"] = performances.Sum(p => p.CountHighLevel);
            currentWorksheet.Cells[numRow, "F"] = (float)performances.Sum(p => p.CountHighLevel) / performances.Sum(p => p.CountTotal) * 100F;
            currentWorksheet.Cells[numRow, "I"] = performances.Sum(p => p.CountSufficientLevel);
            currentWorksheet.Cells[numRow, "J"] = (float)performances.Sum(p => p.CountSufficientLevel) / performances.Sum(p => p.CountTotal) * 100F;
            currentWorksheet.Cells[numRow, "M"] = performances.Sum(p => p.CountMidleLevel);
            currentWorksheet.Cells[numRow, "N"] = (float)performances.Sum(p => p.CountMidleLevel) / performances.Sum(p => p.CountTotal) * 100F;
            currentWorksheet.Cells[numRow, "Q"] = performances.Sum(p => p.CountSatisfactoryLevel);
            currentWorksheet.Cells[numRow, "R"] = (float)performances.Sum(p => p.CountSatisfactoryLevel) / performances.Sum(p => p.CountTotal) * 100F;
            currentWorksheet.Cells[numRow, "U"] = performances.Sum(p => p.CountLowLevel);
            currentWorksheet.Cells[numRow, "V"] = (float)performances.Sum(p => p.CountLowLevel) / performances.Sum(p => p.CountTotal) * 100F;        
        }

        private void OutputYearForSubject(List<Performance> performances, int numRow, int numSubject = 1, string nameSubject = "")
        {
            currentWorksheet.Cells[numRow, 1] = numSubject;
            currentWorksheet.Cells[numRow, 2] = nameSubject;
            currentWorksheet.Cells[numRow, 3] = performances.Sum(p => p.CountTotal);
            currentWorksheet.Cells[numRow, 4] = performances.Sum(p => p.CountTotal);

            currentWorksheet.Cells[numRow, "G"] = performances.Sum(p => p.CountHighLevel);
            currentWorksheet.Cells[numRow, "H"] = (float)performances.Sum(p => p.CountHighLevel) / performances.Sum(p => p.CountTotal) * 100F;
            currentWorksheet.Cells[numRow, "K"] = performances.Sum(p => p.CountSufficientLevel);
            currentWorksheet.Cells[numRow, "L"] = (float)performances.Sum(p => p.CountSufficientLevel) / performances.Sum(p => p.CountTotal) * 100F;
            currentWorksheet.Cells[numRow, "O"] = performances.Sum(p => p.CountMidleLevel);
            currentWorksheet.Cells[numRow, "P"] = (float)performances.Sum(p => p.CountMidleLevel) / performances.Sum(p => p.CountTotal) * 100F;
            currentWorksheet.Cells[numRow, "S"] = performances.Sum(p => p.CountSatisfactoryLevel);
            currentWorksheet.Cells[numRow, "T"] = (float)performances.Sum(p => p.CountSatisfactoryLevel) / performances.Sum(p => p.CountTotal) * 100F;
            currentWorksheet.Cells[numRow, "W"] = performances.Sum(p => p.CountLowLevel);
            currentWorksheet.Cells[numRow, "X"] = (float)performances.Sum(p => p.CountLowLevel) / performances.Sum(p => p.CountTotal) * 100F;
        }

        private void OutputExamForSchool(Performance performance, int numRow, int numSchool,string nameSchool = "")
        {
            currentWorksheet.Cells[numRow, 1] = numSchool;
            currentWorksheet.Cells[numRow, 2] = nameSchool;
            if (performance == null)
                return;

            currentWorksheet.Cells[numRow, 2] = performance.EducationalInstitution.Name;
            currentWorksheet.Cells[numRow, 3] = performance.CountTotal;
            currentWorksheet.Cells[numRow, 4] = performance.CountTotal;

            currentWorksheet.Cells[numRow, "E"] = performance.CountHighLevel;
            currentWorksheet.Cells[numRow, "F"] = performance.GetPercentageOfTotal(performance.CountHighLevel);
            currentWorksheet.Cells[numRow, "I"] = performance.CountSufficientLevel;
            currentWorksheet.Cells[numRow, "J"] = performance.GetPercentageOfTotal(performance.CountSufficientLevel);
            currentWorksheet.Cells[numRow, "M"] = performance.CountMidleLevel;
            currentWorksheet.Cells[numRow, "N"] = performance.GetPercentageOfTotal(performance.CountMidleLevel);
            currentWorksheet.Cells[numRow, "Q"] = performance.CountSatisfactoryLevel;
            currentWorksheet.Cells[numRow, "R"] = performance.GetPercentageOfTotal(performance.CountSatisfactoryLevel);
            currentWorksheet.Cells[numRow, "U"] = performance.CountLowLevel;
            currentWorksheet.Cells[numRow, "V"] = performance.GetPercentageOfTotal(performance.CountLowLevel);
        }

        private void OutputYearForSchool(Performance performance, int numRow, int numSchool)
        {
            if (performance == null)
                return;

            currentWorksheet.Cells[numRow, 1] = numSchool;
            currentWorksheet.Cells[numRow, 2] = performance.EducationalInstitution.Name;
            currentWorksheet.Cells[numRow, 3] = performance.CountTotal;
            currentWorksheet.Cells[numRow, 4] = performance.CountTotal;

            currentWorksheet.Cells[numRow, "G"] = performance.CountHighLevel;
            currentWorksheet.Cells[numRow, "H"] = performance.GetPercentageOfTotal(performance.CountHighLevel);
            currentWorksheet.Cells[numRow, "K"] = performance.CountSufficientLevel;
            currentWorksheet.Cells[numRow, "L"] = performance.GetPercentageOfTotal(performance.CountSufficientLevel);
            currentWorksheet.Cells[numRow, "O"] = performance.CountMidleLevel;
            currentWorksheet.Cells[numRow, "P"] = performance.GetPercentageOfTotal(performance.CountMidleLevel);
            currentWorksheet.Cells[numRow, "S"] = performance.CountSatisfactoryLevel;
            currentWorksheet.Cells[numRow, "T"] = performance.GetPercentageOfTotal(performance.CountSatisfactoryLevel);
            currentWorksheet.Cells[numRow, "W"] = performance.CountLowLevel;
            currentWorksheet.Cells[numRow, "X"] = performance.GetPercentageOfTotal(performance.CountLowLevel);
        }

        private void OutputHeaderExamYear(ref Worksheet worksheet, string Year = "")//, int rowStart = 1)
        {
            worksheet.Cells[1, 1] = Year;
            worksheet.Range["A9", "A12"].Merge();
            worksheet.Cells[9, 1] = "№ п / п";
            worksheet.Range["B9", "B12"].Merge(Type.Missing);
            worksheet.Cells[9, 2] = "Предмет";
            worksheet.Range["C9", "C12"].Merge(Type.Missing);
            worksheet.Cells[9, 3] = "Общее кол-во учащихся";
            worksheet.Range["D9", "D12"].Merge(Type.Missing);
            worksheet.Cells[9, 4] = "Кол-во учащихся, сдававших экзамен";
            worksheet.Range["E9", "Y9"].Merge(Type.Missing);
            worksheet.Cells[9, "E"] = "Результаты экзаменов.";
            worksheet.Range["E10", "H10"].Merge(Type.Missing);
            worksheet.Cells[10, "E"] = "Высокий уровень";
            worksheet.Range["I10", "L10"].Merge(Type.Missing);
            worksheet.Cells[10, "I"] = "Достаточный уровень";
            worksheet.Range["M10", "P10"].Merge(Type.Missing);
            worksheet.Cells[10, "M"] = "Средний уровень";
            worksheet.Range["Q10", "T10"].Merge(Type.Missing);
            worksheet.Cells[10, "Q"] = "Удовлетворительный уровень";
            worksheet.Range["U10", "X10"].Merge(Type.Missing);
            worksheet.Cells[10, "U"] = "Низкий уровень";
            worksheet.Range["Y10", "Y12"].Merge(Type.Missing);
            worksheet.Cells[10, "Y"] = "Не сдали экзамен";

            worksheet.Range["E11", "F11"].Merge(Type.Missing);
            worksheet.Cells[11, "E"] = "Экзамен";
            worksheet.Range["G11", "H11"].Merge(Type.Missing);
            worksheet.Cells[11, "I"] = "Год";
            worksheet.Range["I11", "G11"].Merge(Type.Missing);
            worksheet.Cells[11, "I"] = "Экзамен";
            worksheet.Range["K11", "L11"].Merge(Type.Missing);
            worksheet.Cells[11, "K"] = "Год";
            worksheet.Range["M11", "N11"].Merge(Type.Missing);
            worksheet.Cells[11, "M"] = "Экзамен";
            worksheet.Range["O11", "P11"].Merge(Type.Missing);
            worksheet.Cells[11, "O"] = "Год";
            worksheet.Range["Q11", "R11"].Merge(Type.Missing);
            worksheet.Cells[11, "Q"] = "Экзамен";
            worksheet.Range["S11", "T11"].Merge(Type.Missing);
            worksheet.Cells[11, "S"] = "Год";
            worksheet.Range["U11", "V11"].Merge(Type.Missing);
            worksheet.Cells[11, "U"] = "Экзамен";
            worksheet.Range["W11", "X11"].Merge(Type.Missing);
            worksheet.Cells[11, "W"] = "Год";

            
            worksheet.Cells[12, "E"] = "Кол-во";
            worksheet.Cells[12, "F"] = "%";
            worksheet.Cells[12, "G"] = "Кол-во";
            worksheet.Cells[12, "H"] = "%";
            worksheet.Cells[12, "I"] = "Кол-во";
            worksheet.Cells[12, "J"] = "%";
            worksheet.Cells[12, "K"] = "Кол-во";
            worksheet.Cells[12, "L"] = "%";
            worksheet.Cells[12, "M"] = "Кол-во";
            worksheet.Cells[12, "N"] = "%";
            worksheet.Cells[12, "O"] = "Кол-во";
            worksheet.Cells[12, "P"] = "%";
            worksheet.Cells[12, "Q"] = "Кол-во";
            worksheet.Cells[12, "R"] = "%";
            worksheet.Cells[12, "S"] = "Кол-во";
            worksheet.Cells[12, "T"] = "%";
            worksheet.Cells[12, "U"] = "Кол-во";
            worksheet.Cells[12, "V"] = "%";
            worksheet.Cells[12, "W"] = "Кол-во";
            worksheet.Cells[12, "X"] = "%";

            worksheet.Range["A9", "Y12"].HorizontalAlignment = XlVAlign.xlVAlignCenter;
            worksheet.Range["A9", "Y12"].VerticalAlignment = XlVAlign.xlVAlignCenter;
            worksheet.Range["A9", "Y12"].WrapText = true;
        }
    }
}
