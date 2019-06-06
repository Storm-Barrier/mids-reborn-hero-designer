﻿namespace Hero_Designer
{

    public partial class frmPowerEffect : global::System.Windows.Forms.Form
    {

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }


        [global::System.Diagnostics.DebuggerStepThrough]
        private void InitializeComponent()
        {
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Hero_Designer.frmPowerEffect));
            this.btnPaste = new global::System.Windows.Forms.Button();
            this.btnCopy = new global::System.Windows.Forms.Button();
            this.chkStack = new global::System.Windows.Forms.CheckBox();
            this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
            this.clbSuppression = new global::System.Windows.Forms.CheckedListBox();
            this.Label27 = new global::System.Windows.Forms.Label();
            this.rbIfPlayer = new global::System.Windows.Forms.RadioButton();
            this.rbIfCritter = new global::System.Windows.Forms.RadioButton();
            this.rbIfAny = new global::System.Windows.Forms.RadioButton();
            this.chkFXResistable = new global::System.Windows.Forms.CheckBox();
            this.chkFXBuffable = new global::System.Windows.Forms.CheckBox();
            this.Label26 = new global::System.Windows.Forms.Label();
            this.txtFXProb = new global::System.Windows.Forms.TextBox();
            this.Label25 = new global::System.Windows.Forms.Label();
            this.txtFXDelay = new global::System.Windows.Forms.TextBox();
            this.Label24 = new global::System.Windows.Forms.Label();
            this.txtFXTicks = new global::System.Windows.Forms.TextBox();
            this.Label23 = new global::System.Windows.Forms.Label();
            this.txtFXDuration = new global::System.Windows.Forms.TextBox();
            this.Label22 = new global::System.Windows.Forms.Label();
            this.txtFXMag = new global::System.Windows.Forms.TextBox();
            this.Label28 = new global::System.Windows.Forms.Label();
            this.Label30 = new global::System.Windows.Forms.Label();
            this.cbFXClass = new global::System.Windows.Forms.ComboBox();
            this.cbFXSpecialCase = new global::System.Windows.Forms.ComboBox();
            this.btnOK = new global::System.Windows.Forms.Button();
            this.btnCancel = new global::System.Windows.Forms.Button();
            this.lblEffectDescription = new global::System.Windows.Forms.Label();
            this.chkVariable = new global::System.Windows.Forms.CheckBox();
            this.cbPercentageOverride = new global::System.Windows.Forms.ComboBox();
            this.Label2 = new global::System.Windows.Forms.Label();
            this.Label1 = new global::System.Windows.Forms.Label();
            this.txtFXScale = new global::System.Windows.Forms.TextBox();
            this.Label3 = new global::System.Windows.Forms.Label();
            this.cbAffects = new global::System.Windows.Forms.ComboBox();
            this.Label4 = new global::System.Windows.Forms.Label();
            this.cbAttribute = new global::System.Windows.Forms.ComboBox();
            this.Label5 = new global::System.Windows.Forms.Label();
            this.cbAspect = new global::System.Windows.Forms.ComboBox();
            this.Label6 = new global::System.Windows.Forms.Label();
            this.cbModifier = new global::System.Windows.Forms.ComboBox();
            this.chkNearGround = new global::System.Windows.Forms.CheckBox();
            this.lblAffectsCaster = new global::System.Windows.Forms.Label();
            this.lvEffectType = new global::System.Windows.Forms.ListView();
            this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
            this.lvSubAttribute = new global::System.Windows.Forms.ListView();
            this.chSub = new global::System.Windows.Forms.ColumnHeader();
            this.lblProb = new global::System.Windows.Forms.Label();
            this.lvSubSub = new global::System.Windows.Forms.ListView();
            this.chSubSub = new global::System.Windows.Forms.ColumnHeader();
            this.Label7 = new global::System.Windows.Forms.Label();
            this.Label8 = new global::System.Windows.Forms.Label();
            this.btnCSV = new global::System.Windows.Forms.Button();
            this.Label9 = new global::System.Windows.Forms.Label();
            this.cmbEffectId = new global::System.Windows.Forms.ComboBox();
            this.IgnoreED = new global::System.Windows.Forms.CheckBox();
            this.Label10 = new global::System.Windows.Forms.Label();
            this.txtOverride = new global::System.Windows.Forms.TextBox();
            this.Label11 = new global::System.Windows.Forms.Label();
            this.txtPPM = new global::System.Windows.Forms.TextBox();
            this.GroupBox3.SuspendLayout();
            base.SuspendLayout();
            global::System.Drawing.Point point = new global::System.Drawing.Point(804, 497);
            this.btnPaste.Location = point;
            this.btnPaste.Name = "btnPaste";
            global::System.Drawing.Size size = new global::System.Drawing.Size(150, 26);
            this.btnPaste.Size = size;
            this.btnPaste.TabIndex = 116;
            this.btnPaste.Text = "Paste Effect Data";
            point = new global::System.Drawing.Point(804, 465);
            this.btnCopy.Location = point;
            this.btnCopy.Name = "btnCopy";
            size = new global::System.Drawing.Size(150, 26);
            this.btnCopy.Size = size;
            this.btnCopy.TabIndex = 115;
            this.btnCopy.Text = "Copy Effect Data";
            this.chkStack.CheckAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(20, 510);
            this.chkStack.Location = point;
            this.chkStack.Name = "chkStack";
            size = new global::System.Drawing.Size(172, 20);
            this.chkStack.Size = size;
            this.chkStack.TabIndex = 112;
            this.chkStack.Text = "Effect Can Stack";
            this.chkStack.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.GroupBox3.Controls.Add(this.clbSuppression);
            point = new global::System.Drawing.Point(794, 124);
            this.GroupBox3.Location = point;
            this.GroupBox3.Name = "GroupBox3";
            size = new global::System.Drawing.Size(166, 240);
            this.GroupBox3.Size = size;
            this.GroupBox3.TabIndex = 107;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Suppression";
            this.clbSuppression.FormattingEnabled = true;
            point = new global::System.Drawing.Point(10, 19);
            this.clbSuppression.Location = point;
            this.clbSuppression.Name = "clbSuppression";
            size = new global::System.Drawing.Size(150, 214);
            this.clbSuppression.Size = size;
            this.clbSuppression.TabIndex = 0;
            point = new global::System.Drawing.Point(12, 596);
            this.Label27.Location = point;
            this.Label27.Name = "Label27";
            size = new global::System.Drawing.Size(76, 20);
            this.Label27.Size = size;
            this.Label27.TabIndex = 102;
            this.Label27.Text = "If Target =";
            this.Label27.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(224, 597);
            this.rbIfPlayer.Location = point;
            this.rbIfPlayer.Name = "rbIfPlayer";
            size = new global::System.Drawing.Size(76, 20);
            this.rbIfPlayer.Size = size;
            this.rbIfPlayer.TabIndex = 88;
            this.rbIfPlayer.Text = "Players";
            point = new global::System.Drawing.Point(147, 597);
            this.rbIfCritter.Location = point;
            this.rbIfCritter.Name = "rbIfCritter";
            size = new global::System.Drawing.Size(71, 20);
            this.rbIfCritter.Size = size;
            this.rbIfCritter.TabIndex = 87;
            this.rbIfCritter.Text = "Critters";
            this.rbIfAny.Checked = true;
            point = new global::System.Drawing.Point(94, 597);
            this.rbIfAny.Location = point;
            this.rbIfAny.Name = "rbIfAny";
            size = new global::System.Drawing.Size(57, 20);
            this.rbIfAny.Size = size;
            this.rbIfAny.TabIndex = 86;
            this.rbIfAny.TabStop = true;
            this.rbIfAny.Text = "Any";
            this.chkFXResistable.CheckAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(20, 561);
            this.chkFXResistable.Location = point;
            this.chkFXResistable.Name = "chkFXResistable";
            size = new global::System.Drawing.Size(172, 20);
            this.chkFXResistable.Size = size;
            this.chkFXResistable.TabIndex = 90;
            this.chkFXResistable.Text = "Effect is Unresistible";
            this.chkFXResistable.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.chkFXBuffable.CheckAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(20, 528);
            this.chkFXBuffable.Location = point;
            this.chkFXBuffable.Name = "chkFXBuffable";
            size = new global::System.Drawing.Size(172, 20);
            this.chkFXBuffable.Size = size;
            this.chkFXBuffable.TabIndex = 89;
            this.chkFXBuffable.Text = "Ignore Buffs / Enhancements";
            this.chkFXBuffable.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(12, 273);
            this.Label26.Location = point;
            this.Label26.Name = "Label26";
            size = new global::System.Drawing.Size(76, 20);
            this.Label26.Size = size;
            this.Label26.TabIndex = 101;
            this.Label26.Text = "Probability:";
            this.Label26.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(96, 273);
            this.txtFXProb.Location = point;
            this.txtFXProb.Name = "txtFXProb";
            size = new global::System.Drawing.Size(42, 20);
            this.txtFXProb.Size = size;
            this.txtFXProb.TabIndex = 85;
            this.txtFXProb.Text = "1";
            point = new global::System.Drawing.Point(12, 247);
            this.Label25.Location = point;
            this.Label25.Name = "Label25";
            size = new global::System.Drawing.Size(76, 20);
            this.Label25.Size = size;
            this.Label25.TabIndex = 100;
            this.Label25.Text = "Delay Time:";
            this.Label25.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(96, 247);
            this.txtFXDelay.Location = point;
            this.txtFXDelay.Name = "txtFXDelay";
            size = new global::System.Drawing.Size(42, 20);
            this.txtFXDelay.Size = size;
            this.txtFXDelay.TabIndex = 84;
            this.txtFXDelay.Text = "0";
            point = new global::System.Drawing.Point(14, 221);
            this.Label24.Location = point;
            this.Label24.Name = "Label24";
            size = new global::System.Drawing.Size(76, 20);
            this.Label24.Size = size;
            this.Label24.TabIndex = 99;
            this.Label24.Text = "Ticks:";
            this.Label24.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(96, 221);
            this.txtFXTicks.Location = point;
            this.txtFXTicks.Name = "txtFXTicks";
            size = new global::System.Drawing.Size(42, 20);
            this.txtFXTicks.Size = size;
            this.txtFXTicks.TabIndex = 83;
            this.txtFXTicks.Text = "0";
            point = new global::System.Drawing.Point(14, 169);
            this.Label23.Location = point;
            this.Label23.Name = "Label23";
            size = new global::System.Drawing.Size(76, 20);
            this.Label23.Size = size;
            this.Label23.TabIndex = 98;
            this.Label23.Text = "Duration:";
            this.Label23.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(96, 169);
            this.txtFXDuration.Location = point;
            this.txtFXDuration.Name = "txtFXDuration";
            size = new global::System.Drawing.Size(42, 20);
            this.txtFXDuration.Size = size;
            this.txtFXDuration.TabIndex = 82;
            this.txtFXDuration.Text = "0";
            point = new global::System.Drawing.Point(14, 195);
            this.Label22.Location = point;
            this.Label22.Name = "Label22";
            size = new global::System.Drawing.Size(76, 20);
            this.Label22.Size = size;
            this.Label22.TabIndex = 97;
            this.Label22.Text = "Magnitude:";
            this.Label22.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(96, 195);
            this.txtFXMag.Location = point;
            this.txtFXMag.Name = "txtFXMag";
            size = new global::System.Drawing.Size(42, 20);
            this.txtFXMag.Size = size;
            this.txtFXMag.TabIndex = 80;
            this.txtFXMag.Text = "0";
            point = new global::System.Drawing.Point(202, 118);
            this.Label28.Location = point;
            this.Label28.Name = "Label28";
            size = new global::System.Drawing.Size(98, 20);
            this.Label28.Size = size;
            this.Label28.TabIndex = 104;
            this.Label28.Text = "DIsplay Priority:";
            this.Label28.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(408, 597);
            this.Label30.Location = point;
            this.Label30.Name = "Label30";
            size = new global::System.Drawing.Size(76, 20);
            this.Label30.Size = size;
            this.Label30.TabIndex = 105;
            this.Label30.Text = "Special Case:";
            this.Label30.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.cbFXClass.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            point = new global::System.Drawing.Point(306, 116);
            this.cbFXClass.Location = point;
            this.cbFXClass.Name = "cbFXClass";
            size = new global::System.Drawing.Size(132, 22);
            this.cbFXClass.Size = size;
            this.cbFXClass.TabIndex = 93;
            this.cbFXSpecialCase.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            point = new global::System.Drawing.Point(489, 597);
            this.cbFXSpecialCase.Location = point;
            this.cbFXSpecialCase.Name = "cbFXSpecialCase";
            size = new global::System.Drawing.Size(136, 22);
            this.cbFXSpecialCase.Size = size;
            this.cbFXSpecialCase.TabIndex = 94;
            this.btnOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
            point = new global::System.Drawing.Point(881, 578);
            this.btnOK.Location = point;
            this.btnOK.Name = "btnOK";
            size = new global::System.Drawing.Size(85, 36);
            this.btnOK.Size = size;
            this.btnOK.TabIndex = 119;
            this.btnOK.Text = "OK";
            this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
            point = new global::System.Drawing.Point(794, 578);
            this.btnCancel.Location = point;
            this.btnCancel.Name = "btnCancel";
            size = new global::System.Drawing.Size(85, 36);
            this.btnCancel.Size = size;
            this.btnCancel.TabIndex = 118;
            this.btnCancel.Text = "Cancel";
            this.lblEffectDescription.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
            point = new global::System.Drawing.Point(8, 11);
            this.lblEffectDescription.Location = point;
            this.lblEffectDescription.Name = "lblEffectDescription";
            size = new global::System.Drawing.Size(950, 102);
            this.lblEffectDescription.Size = size;
            this.lblEffectDescription.TabIndex = 120;
            this.lblEffectDescription.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEffectDescription.UseMnemonic = false;
            point = new global::System.Drawing.Point(461, 116);
            this.chkVariable.Location = point;
            this.chkVariable.Name = "chkVariable";
            size = new global::System.Drawing.Size(285, 20);
            this.chkVariable.Size = size;
            this.chkVariable.TabIndex = 126;
            this.chkVariable.Text = "Enable Power Scaling (Override)";
            this.cbPercentageOverride.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            point = new global::System.Drawing.Point(96, 116);
            this.cbPercentageOverride.Location = point;
            this.cbPercentageOverride.Name = "cbPercentageOverride";
            size = new global::System.Drawing.Size(96, 22);
            this.cbPercentageOverride.Size = size;
            this.cbPercentageOverride.TabIndex = 127;
            point = new global::System.Drawing.Point(14, 118);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            size = new global::System.Drawing.Size(76, 20);
            this.Label2.Size = size;
            this.Label2.TabIndex = 128;
            this.Label2.Text = "Percentage:";
            this.Label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(14, 143);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            size = new global::System.Drawing.Size(76, 20);
            this.Label1.Size = size;
            this.Label1.TabIndex = 130;
            this.Label1.Text = "Scale:";
            this.Label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(96, 143);
            this.txtFXScale.Location = point;
            this.txtFXScale.Name = "txtFXScale";
            size = new global::System.Drawing.Size(42, 20);
            this.txtFXScale.Size = size;
            this.txtFXScale.TabIndex = 129;
            this.txtFXScale.Text = "0";
            point = new global::System.Drawing.Point(14, 443);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            size = new global::System.Drawing.Size(76, 20);
            this.Label3.Size = size;
            this.Label3.TabIndex = 132;
            this.Label3.Text = "Affects:";
            this.Label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.cbAffects.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            point = new global::System.Drawing.Point(96, 443);
            this.cbAffects.Location = point;
            this.cbAffects.Name = "cbAffects";
            size = new global::System.Drawing.Size(122, 22);
            this.cbAffects.Size = size;
            this.cbAffects.TabIndex = 131;
            point = new global::System.Drawing.Point(14, 328);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            size = new global::System.Drawing.Size(76, 20);
            this.Label4.Size = size;
            this.Label4.TabIndex = 134;
            this.Label4.Text = "AttribType:";
            this.Label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.cbAttribute.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            point = new global::System.Drawing.Point(96, 328);
            this.cbAttribute.Location = point;
            this.cbAttribute.Name = "cbAttribute";
            size = new global::System.Drawing.Size(122, 22);
            this.cbAttribute.Size = size;
            this.cbAttribute.TabIndex = 133;
            point = new global::System.Drawing.Point(14, 356);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            size = new global::System.Drawing.Size(76, 20);
            this.Label5.Size = size;
            this.Label5.TabIndex = 136;
            this.Label5.Text = "Aspect:";
            this.Label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.cbAspect.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            point = new global::System.Drawing.Point(96, 356);
            this.cbAspect.Location = point;
            this.cbAspect.Name = "cbAspect";
            size = new global::System.Drawing.Size(122, 22);
            this.cbAspect.Size = size;
            this.cbAspect.TabIndex = 135;
            point = new global::System.Drawing.Point(14, 384);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            size = new global::System.Drawing.Size(178, 20);
            this.Label6.Size = size;
            this.Label6.TabIndex = 138;
            this.Label6.Text = "Modifier Table:";
            this.Label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
            this.cbModifier.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            point = new global::System.Drawing.Point(20, 405);
            this.cbModifier.Location = point;
            this.cbModifier.Name = "cbModifier";
            size = new global::System.Drawing.Size(198, 22);
            this.cbModifier.Size = size;
            this.cbModifier.TabIndex = 137;
            this.chkNearGround.CheckAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(20, 577);
            this.chkNearGround.Location = point;
            this.chkNearGround.Name = "chkNearGround";
            size = new global::System.Drawing.Size(172, 20);
            this.chkNearGround.Size = size;
            this.chkNearGround.TabIndex = 139;
            this.chkNearGround.Text = "Target must be Near Ground";
            this.chkNearGround.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            this.lblAffectsCaster.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
            point = new global::System.Drawing.Point(96, 464);
            this.lblAffectsCaster.Location = point;
            this.lblAffectsCaster.Name = "lblAffectsCaster";
            size = new global::System.Drawing.Size(122, 32);
            this.lblAffectsCaster.Size = size;
            this.lblAffectsCaster.TabIndex = 140;
            this.lblAffectsCaster.Text = "Power also affects caster";
            this.lblAffectsCaster.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
            this.lvEffectType.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
            {
                this.ColumnHeader1
            });
            this.lvEffectType.FullRowSelect = true;
            this.lvEffectType.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvEffectType.HideSelection = false;
            point = new global::System.Drawing.Point(224, 143);
            this.lvEffectType.Location = point;
            this.lvEffectType.MultiSelect = false;
            this.lvEffectType.Name = "lvEffectType";
            size = new global::System.Drawing.Size(197, 447);
            this.lvEffectType.Size = size;
            this.lvEffectType.TabIndex = 141;
            this.lvEffectType.UseCompatibleStateImageBehavior = false;
            this.lvEffectType.View = global::System.Windows.Forms.View.Details;
            this.ColumnHeader1.Text = "Effect Attribute";
            this.ColumnHeader1.Width = 174;
            this.lvSubAttribute.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
            {
                this.chSub
            });
            this.lvSubAttribute.FullRowSelect = true;
            this.lvSubAttribute.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSubAttribute.HideSelection = false;
            point = new global::System.Drawing.Point(427, 143);
            this.lvSubAttribute.Location = point;
            this.lvSubAttribute.MultiSelect = false;
            this.lvSubAttribute.Name = "lvSubAttribute";
            size = new global::System.Drawing.Size(197, 447);
            this.lvSubAttribute.Size = size;
            this.lvSubAttribute.TabIndex = 142;
            this.lvSubAttribute.UseCompatibleStateImageBehavior = false;
            this.lvSubAttribute.View = global::System.Windows.Forms.View.Details;
            this.chSub.Text = "Sub-Attribute";
            this.chSub.Width = 173;
            point = new global::System.Drawing.Point(142, 273);
            this.lblProb.Location = point;
            this.lblProb.Name = "lblProb";
            size = new global::System.Drawing.Size(76, 20);
            this.lblProb.Size = size;
            this.lblProb.TabIndex = 143;
            this.lblProb.Text = "(100%)";
            this.lblProb.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
            this.lvSubSub.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
            {
                this.chSubSub
            });
            this.lvSubSub.FullRowSelect = true;
            this.lvSubSub.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSubSub.HideSelection = false;
            point = new global::System.Drawing.Point(630, 143);
            this.lvSubSub.Location = point;
            this.lvSubSub.MultiSelect = false;
            this.lvSubSub.Name = "lvSubSub";
            size = new global::System.Drawing.Size(158, 447);
            this.lvSubSub.Size = size;
            this.lvSubSub.TabIndex = 144;
            this.lvSubSub.UseCompatibleStateImageBehavior = false;
            this.lvSubSub.View = global::System.Windows.Forms.View.Details;
            this.chSubSub.Text = "Sub-Sub";
            this.chSubSub.Width = 130;
            point = new global::System.Drawing.Point(144, 247);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            size = new global::System.Drawing.Size(76, 20);
            this.Label7.Size = size;
            this.Label7.TabIndex = 145;
            this.Label7.Text = "s";
            this.Label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
            point = new global::System.Drawing.Point(142, 169);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            size = new global::System.Drawing.Size(76, 20);
            this.Label8.Size = size;
            this.Label8.TabIndex = 146;
            this.Label8.Text = "s";
            this.Label8.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
            point = new global::System.Drawing.Point(804, 529);
            this.btnCSV.Location = point;
            this.btnCSV.Name = "btnCSV";
            size = new global::System.Drawing.Size(150, 26);
            this.btnCSV.Size = size;
            this.btnCSV.TabIndex = 147;
            this.btnCSV.Text = "Import from CSV String";
            point = new global::System.Drawing.Point(794, 367);
            this.Label9.Location = point;
            this.Label9.Name = "Label9";
            size = new global::System.Drawing.Size(160, 20);
            this.Label9.Size = size;
            this.Label9.TabIndex = 149;
            this.Label9.Text = "GlobalChanceMod Flag:";
            this.cmbEffectId.FormattingEnabled = true;
            point = new global::System.Drawing.Point(795, 389);
            this.cmbEffectId.Location = point;
            this.cmbEffectId.Name = "cmbEffectId";
            size = new global::System.Drawing.Size(159, 22);
            this.cmbEffectId.Size = size;
            this.cmbEffectId.TabIndex = 150;
            this.IgnoreED.CheckAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(20, 544);
            this.IgnoreED.Location = point;
            this.IgnoreED.Name = "IgnoreED";
            size = new global::System.Drawing.Size(172, 20);
            this.IgnoreED.Size = size;
            this.IgnoreED.TabIndex = 151;
            this.IgnoreED.Text = "Ignore ED";
            this.IgnoreED.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(794, 417);
            this.Label10.Location = point;
            this.Label10.Name = "Label10";
            size = new global::System.Drawing.Size(160, 20);
            this.Label10.Size = size;
            this.Label10.TabIndex = 152;
            this.Label10.Text = "Override:";
            point = new global::System.Drawing.Point(797, 435);
            this.txtOverride.Location = point;
            this.txtOverride.Name = "txtOverride";
            size = new global::System.Drawing.Size(157, 20);
            this.txtOverride.Size = size;
            this.txtOverride.TabIndex = 153;
            point = new global::System.Drawing.Point(14, 299);
            this.Label11.Location = point;
            this.Label11.Name = "Label11";
            size = new global::System.Drawing.Size(76, 20);
            this.Label11.Size = size;
            this.Label11.TabIndex = 155;
            this.Label11.Text = "PPM:";
            this.Label11.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
            point = new global::System.Drawing.Point(96, 299);
            this.txtPPM.Location = point;
            this.txtPPM.Name = "txtPPM";
            size = new global::System.Drawing.Size(42, 20);
            this.txtPPM.Size = size;
            this.txtPPM.TabIndex = 154;
            this.txtPPM.Text = "0";
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
            size = new global::System.Drawing.Size(971, 626);
            base.ClientSize = size;
            base.Controls.Add(this.Label11);
            base.Controls.Add(this.txtPPM);
            base.Controls.Add(this.txtOverride);
            base.Controls.Add(this.Label10);
            base.Controls.Add(this.IgnoreED);
            base.Controls.Add(this.cmbEffectId);
            base.Controls.Add(this.Label9);
            base.Controls.Add(this.btnCSV);
            base.Controls.Add(this.Label8);
            base.Controls.Add(this.Label7);
            base.Controls.Add(this.lvSubSub);
            base.Controls.Add(this.lblProb);
            base.Controls.Add(this.lvSubAttribute);
            base.Controls.Add(this.lvEffectType);
            base.Controls.Add(this.chkNearGround);
            base.Controls.Add(this.Label6);
            base.Controls.Add(this.cbModifier);
            base.Controls.Add(this.Label5);
            base.Controls.Add(this.cbAspect);
            base.Controls.Add(this.Label4);
            base.Controls.Add(this.cbAttribute);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.cbAffects);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.txtFXScale);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.cbPercentageOverride);
            base.Controls.Add(this.chkVariable);
            base.Controls.Add(this.lblEffectDescription);
            base.Controls.Add(this.btnOK);
            base.Controls.Add(this.btnCancel);
            base.Controls.Add(this.btnPaste);
            base.Controls.Add(this.btnCopy);
            base.Controls.Add(this.chkStack);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.Label27);
            base.Controls.Add(this.rbIfPlayer);
            base.Controls.Add(this.rbIfCritter);
            base.Controls.Add(this.rbIfAny);
            base.Controls.Add(this.chkFXResistable);
            base.Controls.Add(this.chkFXBuffable);
            base.Controls.Add(this.Label26);
            base.Controls.Add(this.txtFXProb);
            base.Controls.Add(this.Label25);
            base.Controls.Add(this.txtFXDelay);
            base.Controls.Add(this.Label24);
            base.Controls.Add(this.txtFXTicks);
            base.Controls.Add(this.Label23);
            base.Controls.Add(this.txtFXDuration);
            base.Controls.Add(this.Label22);
            base.Controls.Add(this.txtFXMag);
            base.Controls.Add(this.Label28);
            base.Controls.Add(this.Label30);
            base.Controls.Add(this.cbFXClass);
            base.Controls.Add(this.cbFXSpecialCase);
            base.Controls.Add(this.lblAffectsCaster);
            this.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmPowerEffect";
            base.ShowInTaskbar = false;
            base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Effect";
            this.GroupBox3.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }


        private global::System.ComponentModel.IContainer components;
    }
}
