﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Proba2
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Регист анкеты.
    /// </summary>
    // *** Start programmer edit section *** (РегистАнкеты CustomAttributes)

    // *** End programmer edit section *** (РегистАнкеты CustomAttributes)
    [AutoAltered()]
    [Caption("Регист анкеты")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("РегистАнкетыE", new string[] {
            "ДатаРегистр as \'Дата регистр\'",
            "ФИОКандид as \'ФИО\'",
            "СерНомПаспорта as \'Сер ном паспорта\'",
            "ИНН as \'ИНН\'",
            "Снилс as \'Снилс\'",
            "НомерТелефона as \'Номер телефона\'",
            "ЭлПочта as \'Эл почта\'",
            "ВакантДолжн as \'Вакантная должность\'",
            "ВакантДолжн.Должность as \'Должность\'",
            "Организация as \'Организация\'",
            "Организация.Наименование as \'Наименование\'"}, Hidden=new string[] {
            "ВакантДолжн.Должность",
            "Организация.Наименование"})]
    [MasterViewDefineAttribute("РегистАнкетыE", "ВакантДолжн", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Должность")]
    [MasterViewDefineAttribute("РегистАнкетыE", "Организация", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [View("РегистАнкетыL", new string[] {
            "ДатаРегистр as \'Дата регистр\'",
            "ФИОКандид as \'ФИО\'",
            "СерНомПаспорта as \'Сер ном паспорта\'",
            "ИНН as \'ИНН\'",
            "Снилс as \'Снилс\'",
            "НомерТелефона as \'Номер телефона\'",
            "ЭлПочта as \'Эл почта\'",
            "ВакантДолжн.Должность as \'Вакантная должность\'",
            "Организация.Наименование as \'Наименование\'"})]
    public class РегистАнкеты : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДатаРегистр = System.DateTime.Now;
        
        private string fФИОКандид;
        
        private int fСерНомПаспорта;
        
        private int fИНН;
        
        private int fСнилс;
        
        private int fНомерТелефона;
        
        private string fЭлПочта;
        
        private IIS.Proba2.ВакантДолжн fВакантДолжн;
        
        private IIS.Proba2.Организация fОрганизация;
        
        // *** Start programmer edit section *** (РегистАнкеты CustomMembers)

        // *** End programmer edit section *** (РегистАнкеты CustomMembers)

        
        /// <summary>
        /// ДатаРегистр.
        /// </summary>
        // *** Start programmer edit section *** (РегистАнкеты.ДатаРегистр CustomAttributes)

        // *** End programmer edit section *** (РегистАнкеты.ДатаРегистр CustomAttributes)
        public virtual System.DateTime ДатаРегистр
        {
            get
            {
                // *** Start programmer edit section *** (РегистАнкеты.ДатаРегистр Get start)

                // *** End programmer edit section *** (РегистАнкеты.ДатаРегистр Get start)
                System.DateTime result = this.fДатаРегистр;
                // *** Start programmer edit section *** (РегистАнкеты.ДатаРегистр Get end)

                // *** End programmer edit section *** (РегистАнкеты.ДатаРегистр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистАнкеты.ДатаРегистр Set start)

                // *** End programmer edit section *** (РегистАнкеты.ДатаРегистр Set start)
                this.fДатаРегистр = value;
                // *** Start programmer edit section *** (РегистАнкеты.ДатаРегистр Set end)

                // *** End programmer edit section *** (РегистАнкеты.ДатаРегистр Set end)
            }
        }
        
        /// <summary>
        /// ИНН.
        /// </summary>
        // *** Start programmer edit section *** (РегистАнкеты.ИНН CustomAttributes)

        // *** End programmer edit section *** (РегистАнкеты.ИНН CustomAttributes)
        public virtual int ИНН
        {
            get
            {
                // *** Start programmer edit section *** (РегистАнкеты.ИНН Get start)

                // *** End programmer edit section *** (РегистАнкеты.ИНН Get start)
                int result = this.fИНН;
                // *** Start programmer edit section *** (РегистАнкеты.ИНН Get end)

                // *** End programmer edit section *** (РегистАнкеты.ИНН Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистАнкеты.ИНН Set start)

                // *** End programmer edit section *** (РегистАнкеты.ИНН Set start)
                this.fИНН = value;
                // *** Start programmer edit section *** (РегистАнкеты.ИНН Set end)

                // *** End programmer edit section *** (РегистАнкеты.ИНН Set end)
            }
        }
        
        /// <summary>
        /// НомерТелефона.
        /// </summary>
        // *** Start programmer edit section *** (РегистАнкеты.НомерТелефона CustomAttributes)

        // *** End programmer edit section *** (РегистАнкеты.НомерТелефона CustomAttributes)
        public virtual int НомерТелефона
        {
            get
            {
                // *** Start programmer edit section *** (РегистАнкеты.НомерТелефона Get start)

                // *** End programmer edit section *** (РегистАнкеты.НомерТелефона Get start)
                int result = this.fНомерТелефона;
                // *** Start programmer edit section *** (РегистАнкеты.НомерТелефона Get end)

                // *** End programmer edit section *** (РегистАнкеты.НомерТелефона Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистАнкеты.НомерТелефона Set start)

                // *** End programmer edit section *** (РегистАнкеты.НомерТелефона Set start)
                this.fНомерТелефона = value;
                // *** Start programmer edit section *** (РегистАнкеты.НомерТелефона Set end)

                // *** End programmer edit section *** (РегистАнкеты.НомерТелефона Set end)
            }
        }
        
        /// <summary>
        /// СерНомПаспорта.
        /// </summary>
        // *** Start programmer edit section *** (РегистАнкеты.СерНомПаспорта CustomAttributes)

        // *** End programmer edit section *** (РегистАнкеты.СерНомПаспорта CustomAttributes)
        public virtual int СерНомПаспорта
        {
            get
            {
                // *** Start programmer edit section *** (РегистАнкеты.СерНомПаспорта Get start)

                // *** End programmer edit section *** (РегистАнкеты.СерНомПаспорта Get start)
                int result = this.fСерНомПаспорта;
                // *** Start programmer edit section *** (РегистАнкеты.СерНомПаспорта Get end)

                // *** End programmer edit section *** (РегистАнкеты.СерНомПаспорта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистАнкеты.СерНомПаспорта Set start)

                // *** End programmer edit section *** (РегистАнкеты.СерНомПаспорта Set start)
                this.fСерНомПаспорта = value;
                // *** Start programmer edit section *** (РегистАнкеты.СерНомПаспорта Set end)

                // *** End programmer edit section *** (РегистАнкеты.СерНомПаспорта Set end)
            }
        }
        
        /// <summary>
        /// Снилс.
        /// </summary>
        // *** Start programmer edit section *** (РегистАнкеты.Снилс CustomAttributes)

        // *** End programmer edit section *** (РегистАнкеты.Снилс CustomAttributes)
        public virtual int Снилс
        {
            get
            {
                // *** Start programmer edit section *** (РегистАнкеты.Снилс Get start)

                // *** End programmer edit section *** (РегистАнкеты.Снилс Get start)
                int result = this.fСнилс;
                // *** Start programmer edit section *** (РегистАнкеты.Снилс Get end)

                // *** End programmer edit section *** (РегистАнкеты.Снилс Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистАнкеты.Снилс Set start)

                // *** End programmer edit section *** (РегистАнкеты.Снилс Set start)
                this.fСнилс = value;
                // *** Start programmer edit section *** (РегистАнкеты.Снилс Set end)

                // *** End programmer edit section *** (РегистАнкеты.Снилс Set end)
            }
        }
        
        /// <summary>
        /// ФИОКандид.
        /// </summary>
        // *** Start programmer edit section *** (РегистАнкеты.ФИОКандид CustomAttributes)

        // *** End programmer edit section *** (РегистАнкеты.ФИОКандид CustomAttributes)
        [StrLen(255)]
        public virtual string ФИОКандид
        {
            get
            {
                // *** Start programmer edit section *** (РегистАнкеты.ФИОКандид Get start)

                // *** End programmer edit section *** (РегистАнкеты.ФИОКандид Get start)
                string result = this.fФИОКандид;
                // *** Start programmer edit section *** (РегистАнкеты.ФИОКандид Get end)

                // *** End programmer edit section *** (РегистАнкеты.ФИОКандид Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистАнкеты.ФИОКандид Set start)

                // *** End programmer edit section *** (РегистАнкеты.ФИОКандид Set start)
                this.fФИОКандид = value;
                // *** Start programmer edit section *** (РегистАнкеты.ФИОКандид Set end)

                // *** End programmer edit section *** (РегистАнкеты.ФИОКандид Set end)
            }
        }
        
        /// <summary>
        /// ЭлПочта.
        /// </summary>
        // *** Start programmer edit section *** (РегистАнкеты.ЭлПочта CustomAttributes)

        // *** End programmer edit section *** (РегистАнкеты.ЭлПочта CustomAttributes)
        [StrLen(255)]
        public virtual string ЭлПочта
        {
            get
            {
                // *** Start programmer edit section *** (РегистАнкеты.ЭлПочта Get start)

                // *** End programmer edit section *** (РегистАнкеты.ЭлПочта Get start)
                string result = this.fЭлПочта;
                // *** Start programmer edit section *** (РегистАнкеты.ЭлПочта Get end)

                // *** End programmer edit section *** (РегистАнкеты.ЭлПочта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистАнкеты.ЭлПочта Set start)

                // *** End programmer edit section *** (РегистАнкеты.ЭлПочта Set start)
                this.fЭлПочта = value;
                // *** Start programmer edit section *** (РегистАнкеты.ЭлПочта Set end)

                // *** End programmer edit section *** (РегистАнкеты.ЭлПочта Set end)
            }
        }
        
        /// <summary>
        /// Регист анкеты.
        /// </summary>
        // *** Start programmer edit section *** (РегистАнкеты.ВакантДолжн CustomAttributes)

        // *** End programmer edit section *** (РегистАнкеты.ВакантДолжн CustomAttributes)
        [PropertyStorage(new string[] {
                "ВакантДолжн"})]
        [NotNull()]
        public virtual IIS.Proba2.ВакантДолжн ВакантДолжн
        {
            get
            {
                // *** Start programmer edit section *** (РегистАнкеты.ВакантДолжн Get start)

                // *** End programmer edit section *** (РегистАнкеты.ВакантДолжн Get start)
                IIS.Proba2.ВакантДолжн result = this.fВакантДолжн;
                // *** Start programmer edit section *** (РегистАнкеты.ВакантДолжн Get end)

                // *** End programmer edit section *** (РегистАнкеты.ВакантДолжн Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистАнкеты.ВакантДолжн Set start)

                // *** End programmer edit section *** (РегистАнкеты.ВакантДолжн Set start)
                this.fВакантДолжн = value;
                // *** Start programmer edit section *** (РегистАнкеты.ВакантДолжн Set end)

                // *** End programmer edit section *** (РегистАнкеты.ВакантДолжн Set end)
            }
        }
        
        /// <summary>
        /// Регист анкеты.
        /// </summary>
        // *** Start programmer edit section *** (РегистАнкеты.Организация CustomAttributes)

        // *** End programmer edit section *** (РегистАнкеты.Организация CustomAttributes)
        [PropertyStorage(new string[] {
                "Организация"})]
        [NotNull()]
        public virtual IIS.Proba2.Организация Организация
        {
            get
            {
                // *** Start programmer edit section *** (РегистАнкеты.Организация Get start)

                // *** End programmer edit section *** (РегистАнкеты.Организация Get start)
                IIS.Proba2.Организация result = this.fОрганизация;
                // *** Start programmer edit section *** (РегистАнкеты.Организация Get end)

                // *** End programmer edit section *** (РегистАнкеты.Организация Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (РегистАнкеты.Организация Set start)

                // *** End programmer edit section *** (РегистАнкеты.Организация Set start)
                this.fОрганизация = value;
                // *** Start programmer edit section *** (РегистАнкеты.Организация Set end)

                // *** End programmer edit section *** (РегистАнкеты.Организация Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "РегистАнкетыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РегистАнкетыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РегистАнкетыE", typeof(IIS.Proba2.РегистАнкеты));
                }
            }
            
            /// <summary>
            /// "РегистАнкетыL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View РегистАнкетыL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("РегистАнкетыL", typeof(IIS.Proba2.РегистАнкеты));
                }
            }
        }
    }
}
