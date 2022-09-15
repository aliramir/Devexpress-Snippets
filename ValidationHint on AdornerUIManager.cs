//Cleaar On Rests
Validation(validationHint1, ValidationHintState.Indeterminate, adornerUIManager1, false);


//Validation Method
private static void Validation(ValidationHint hint, ValidationHintState valid, IAdornerUIManager ctrl, bool visible = false, string msg = "")
        {
            hint.Visible = visible;
            hint.Properties.State = valid;
            hint.Properties.ValidState.Text = msg;
            ctrl.Show();
        }
        
        
// Check On Control Event       
        
private void ServiceName_Leave(object sender, EventArgs e)
        {
            var val = ServiceName.Text;
            var res = SmsPanelBusiness.IsExistServiceName(val, Id);
            if (res)
            {
                Validation(validationHint1,
                    ValidationHintState.Invalid,
                    adornerUIManager1,
                    true, "این مورد قبلا ثبت شده");
                dxErrorProvider1.SetError(ServiceName, "بررسی");
            }
            else
            {
                Validation(validationHint1,
                    ValidationHintState.Indeterminate,
                    adornerUIManager1, false);
            }
        }
