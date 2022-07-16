using AccountingForPerformance.Entities;
using System;

namespace AccountingForPerformance.Interfaces
{
    public interface IReferencesView
    {
        //события редактиррования данных
        event Action btnAddEI_OnClick;
        event Action btnEditEI_OnClick;
        event Action btnRemoveEI_OnClick;
        event Action btnAddAY_OnClick;

        //события отбора данных
        /// <summary>
        /// Смена выбора закладки
        /// </summary>
        event Action CurrentTab_Changed;

        object DataSource { get; set; }  
        object SelectRow { get; }
        int SelectIndexTab { get; }
    }
}
