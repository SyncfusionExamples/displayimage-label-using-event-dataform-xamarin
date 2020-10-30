using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataformXamarin
{
    public class DataformBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.AutoGeneratingDataFormItem += DataForm_AutoGeneratingDataFormItem;
        }
        private void DataForm_AutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.Name == "FirstName")
                    e.DataFormItem.ImageSource = ImageSource.FromFile("contact.png");
            }
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            dataForm.AutoGeneratingDataFormItem += DataForm_AutoGeneratingDataFormItem;
        }
    }
}






