﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using WebVella.ERP.Storage;
using WebVella.ERP.Api.Models;
using WebVella.ERP.Api;

namespace WebVella.ERP
{
    public class ERPService : IERPService
    {
        public static IERPService Current
        {
            get; set;
        }

        public IStorageService StorageService
        {
            get; set;
        }

        public ERPService(IStorageService storage)
        {
            if (Current == null)
                Current = this;

            StorageService = storage;
        }

        public void RunTests()
        {
            EntityTests();
        }

        private void EntityTests()
        {
            Debug.WriteLine("==== START ENTITY TESTS====");


            var entityManager = new EntityManager(StorageService);

            InputEntity inputEntity = new InputEntity();
            //entity.Id = new Guid("C5050AC8-5967-4CE1-95E7-A79B054F9D14");
            inputEntity.Id = Guid.NewGuid();
            inputEntity.Name = "Name of test entity";
            inputEntity.Label = "Display name of test entity";
            inputEntity.PluralLabel = "Plural display name of test entity";
            inputEntity.System = true;

            try
            {
                Entity entity = new Entity(inputEntity);
                List<Field> fields = CreateTestFieldCollection(entity);

                EntityResponse response = entityManager.CreateEntity(inputEntity);

                //FieldResponse fieldResponse = entityManager.CreateField(entity.Id.Value, fields[0]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[1]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[2]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[3]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[4]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[5]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[6]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[7]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[8]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[9]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[10]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[11]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[12]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[13]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[14]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[15]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[16]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[17]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[18]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[19]);
                //fieldResponse = entityManager.CreateField(entity.Id.Value, fields[20]);

                //EntityResponse entityResponse = entityManager.ReadEntity(entity.Id.Value);
                //entity = entityResponse.Object;

                //List<View> views = CreateTestViewCollection(entity);

                //ViewResponse viewResponse = entityManager.CreateView(entity.Id.Value, views[0]);

                //List<Form> forms = CreateTestFormCollection(entity);

                //FormResponse formResponse = entityManager.CreateForm(entity.Id.Value, forms[0]);

                //entityManager.DeleteEntity(entity.Id.Value);

                ////entityManager.ReadEntities();

                EntityResponse resultEntity = entityManager.ReadEntity(entity.Id.Value);
            }
            catch (StorageException e)
            {
                Debug.WriteLine(e);
            }

            Debug.WriteLine("==== END ENTITY TESTS====");
        }

        private List<Field> CreateTestFieldCollection(Entity entity)
        {
            List<Field> fields = new List<Field>();

            AutoNumberField autoNumberField = new AutoNumberField();

            autoNumberField.Id = Guid.NewGuid();
            autoNumberField.Name = "AutoNumber field";
            autoNumberField.Label = "AutoNumber field";
            autoNumberField.PlaceholderText = "AutoNumber field placeholder text";
            autoNumberField.Description = "AutoNumber field description";
            autoNumberField.HelpText = "AutoNumber field help text";
            autoNumberField.Required = true;
            autoNumberField.Unique = true;
            autoNumberField.Searchable = true;
            autoNumberField.Auditable = true;
            autoNumberField.System = true;
            autoNumberField.DefaultValue = 0;

            autoNumberField.DisplayFormat = "A{0000}";
            autoNumberField.StartingNumber = 10;

            fields.Add(autoNumberField);

            CheckboxField checkboxField = new CheckboxField();

            checkboxField.Id = Guid.NewGuid();
            checkboxField.Name = "Checkbox field";
            checkboxField.Label = "Checkbox field";
            checkboxField.PlaceholderText = "Checkbox field placeholder text";
            checkboxField.Description = "Checkbox field description";
            checkboxField.HelpText = "Checkbox field help text";
            checkboxField.Required = true;
            checkboxField.Unique = true;
            checkboxField.Searchable = true;
            checkboxField.Auditable = true;
            checkboxField.System = true;
            checkboxField.DefaultValue = false;

            fields.Add(checkboxField);

            CurrencyField currencyField = new CurrencyField();

            currencyField.Id = Guid.NewGuid();
            currencyField.Name = "Currency field";
            currencyField.Label = "Currency field";
            currencyField.PlaceholderText = "Currency field placeholder text";
            currencyField.Description = "Currency field description";
            currencyField.HelpText = "Currency field help text";
            currencyField.Required = true;
            currencyField.Unique = true;
            currencyField.Searchable = true;
            currencyField.Auditable = true;
            currencyField.System = true;
            currencyField.DefaultValue = 0;

            currencyField.MinValue = 1;
            currencyField.MaxValue = 35;
            currencyField.Currency = new CurrencyTypes();
            currencyField.Currency.CurrencyName = "USD";
            currencyField.Currency.CurrencySymbol = "$";
            currencyField.Currency.Position = CurrencyPosition.AfterTheNumber;

            fields.Add(currencyField);

            DateField dateField = new DateField();

            dateField.Id = Guid.NewGuid();
            dateField.Name = "Date field";
            dateField.Label = "Date field";
            dateField.PlaceholderText = "Date field placeholder text";
            dateField.Description = "Date field description";
            dateField.HelpText = "Date field help text";
            dateField.Required = true;
            dateField.Unique = true;
            dateField.Searchable = true;
            dateField.Auditable = true;
            dateField.System = true;
            dateField.DefaultValue = DateTime.MinValue;

            dateField.Format = "dd.MM.YYYY";

            fields.Add(dateField);

            DateTimeField dateTimeField = new DateTimeField();

            dateTimeField.Id = Guid.NewGuid();
            dateTimeField.Name = "DateTime field";
            dateTimeField.Label = "DateTime field";
            dateTimeField.PlaceholderText = "DateTime field placeholder text";
            dateTimeField.Description = "DateTime field description";
            dateTimeField.HelpText = "DateTime field help text";
            dateTimeField.Required = true;
            dateTimeField.Unique = true;
            dateTimeField.Searchable = true;
            dateTimeField.Auditable = true;
            dateTimeField.System = true;
            dateTimeField.DefaultValue = DateTime.MinValue;

            dateTimeField.Format = "dd.MM.YYYY";

            fields.Add(dateTimeField);

            EmailField emailField = new EmailField();

            emailField.Id = Guid.NewGuid();
            emailField.Name = "Email field";
            emailField.Label = "Email field";
            emailField.PlaceholderText = "Email field placeholder text";
            emailField.Description = "Email field description";
            emailField.HelpText = "Email field help text";
            emailField.Required = true;
            emailField.Unique = true;
            emailField.Searchable = true;
            emailField.Auditable = true;
            emailField.System = true;
            emailField.DefaultValue = "";

            emailField.MaxLength = 255;

            fields.Add(emailField);

            FileField fileField = new FileField();

            fileField.Id = Guid.NewGuid();
            fileField.Name = "File field";
            fileField.Label = "File field";
            fileField.PlaceholderText = "File field placeholder text";
            fileField.Description = "File field description";
            fileField.HelpText = "File field help text";
            fileField.Required = true;
            fileField.Unique = true;
            fileField.Searchable = true;
            fileField.Auditable = true;
            fileField.System = true;
            fileField.DefaultValue = "";

            fields.Add(fileField);

            //FormulaField formulaField = new FormulaField();

            //formulaField.Id = Guid.NewGuid();
            //formulaField.Name = "Formula field";
            //formulaField.Label = "Formula field";
            //formulaField.PlaceholderText = "Formula field placeholder text";
            //formulaField.Description = "Formula field description";
            //formulaField.HelpText = "Formula field help text";
            //formulaField.Required = true;
            //formulaField.Unique = true;
            //formulaField.Searchable = true;
            //formulaField.Auditable = true;
            //formulaField.System = true;

            //formulaField.ReturnType = Api.FormulaFieldReturnType.Number;
            //formulaField.FormulaText = "2 + 5";
            //formulaField.DecimalPlaces = 2;

            //fields.Add(formulaField);

            HtmlField htmlField = new HtmlField();

            htmlField.Id = Guid.NewGuid();
            htmlField.Name = "Html field";
            htmlField.Label = "Html field";
            htmlField.PlaceholderText = "Html field placeholder text";
            htmlField.Description = "Html field description";
            htmlField.HelpText = "Html field help text";
            htmlField.Required = true;
            htmlField.Unique = true;
            htmlField.Searchable = true;
            htmlField.Auditable = true;
            htmlField.System = true;
            htmlField.DefaultValue = "";

            fields.Add(htmlField);

            ImageField imageField = new ImageField();

            imageField.Id = Guid.NewGuid();
            imageField.Name = "Image field";
            imageField.Label = "Image field";
            imageField.PlaceholderText = "Image field placeholder text";
            imageField.Description = "Image field description";
            imageField.HelpText = "Image field help text";
            imageField.Required = true;
            imageField.Unique = true;
            imageField.Searchable = true;
            imageField.Auditable = true;
            imageField.System = true;
            imageField.DefaultValue = "";

            imageField.TargetEntityType = "I don't know";
            imageField.RelationshipName = "Users";

            fields.Add(imageField);

            LookupRelationField lookupRelationField = new LookupRelationField();

            lookupRelationField.Id = Guid.NewGuid();
            lookupRelationField.Name = "LookupRelation field";
            lookupRelationField.Label = "LookupRelation field";
            lookupRelationField.PlaceholderText = "LookupRelation field placeholder text";
            lookupRelationField.Description = "LookupRelation field description";
            lookupRelationField.HelpText = "LookupRelation field help text";
            lookupRelationField.Required = true;
            lookupRelationField.Unique = true;
            lookupRelationField.Searchable = true;
            lookupRelationField.Auditable = true;
            lookupRelationField.System = true;

            lookupRelationField.RelatedEntityId = Guid.Empty;

            fields.Add(lookupRelationField);

            MasterDetailsRelationshipField masterDetailsRelationshipField = new MasterDetailsRelationshipField();

            masterDetailsRelationshipField.Id = Guid.NewGuid();
            masterDetailsRelationshipField.Name = "MasterDetailsRelationship";
            masterDetailsRelationshipField.Label = "Master Details Relationship";
            masterDetailsRelationshipField.PlaceholderText = "MasterDetailsRelationship field placeholder text";
            masterDetailsRelationshipField.Description = "MasterDetailsRelationship field description";
            masterDetailsRelationshipField.HelpText = "MasterDetailsRelationship field help text";
            masterDetailsRelationshipField.Required = true;
            masterDetailsRelationshipField.Unique = true;
            masterDetailsRelationshipField.Searchable = true;
            masterDetailsRelationshipField.Auditable = true;
            masterDetailsRelationshipField.System = true;

            masterDetailsRelationshipField.RelatedEntityId = Guid.Empty;

            fields.Add(masterDetailsRelationshipField);

            MultiLineTextField multiLineTextField = new MultiLineTextField();

            multiLineTextField.Id = Guid.NewGuid();
            multiLineTextField.Name = "MultiLineText field";
            multiLineTextField.Label = "MultiLineText field";
            multiLineTextField.PlaceholderText = "MultiLineText field placeholder text";
            multiLineTextField.Description = "MultiLineText field description";
            multiLineTextField.HelpText = "MultiLineText field help text";
            multiLineTextField.Required = true;
            multiLineTextField.Unique = true;
            multiLineTextField.Searchable = true;
            multiLineTextField.Auditable = true;
            multiLineTextField.System = true;
            multiLineTextField.DefaultValue = "";

            multiLineTextField.MaxLength = 500;
            multiLineTextField.VisibleLineNumber = 10;

            fields.Add(multiLineTextField);

            MultiSelectField multiSelectField = new MultiSelectField();

            multiSelectField.Id = Guid.NewGuid();
            multiSelectField.Name = "MultiSelect field";
            multiSelectField.Label = "MultiSelect field";
            multiSelectField.PlaceholderText = "MultiSelect field placeholder text";
            multiSelectField.Description = "MultiSelect field description";
            multiSelectField.HelpText = "MultiSelect field help text";
            multiSelectField.Required = true;
            multiSelectField.Unique = true;
            multiSelectField.Searchable = true;
            multiSelectField.Auditable = true;
            multiSelectField.System = true;
            multiSelectField.DefaultValue = new string[] { "itemKey1", "itemKey4" };

            multiSelectField.Options = new Dictionary<string, string>();
            multiSelectField.Options.Add("itemKey1", "itemValue1");
            multiSelectField.Options.Add("itemKey2", "itemValue2");
            multiSelectField.Options.Add("itemKey3", "itemValue3");
            multiSelectField.Options.Add("itemKey4", "itemValue4");
            multiSelectField.Options.Add("itemKey5", "itemValue5");
            multiSelectField.Options.Add("itemKey6", "itemValue6");

            fields.Add(multiSelectField);

            NumberField numberField = new NumberField();

            numberField.Id = Guid.NewGuid();
            numberField.Name = "Number field";
            numberField.Label = "Number field";
            numberField.PlaceholderText = "Number field placeholder text";
            numberField.Description = "Number field description";
            numberField.HelpText = "Number field help text";
            numberField.Required = true;
            numberField.Unique = true;
            numberField.Searchable = true;
            numberField.Auditable = true;
            numberField.System = true;
            numberField.DefaultValue = 0;

            numberField.MinValue = 1;
            numberField.MaxValue = 100;
            numberField.DecimalPlaces = 3;

            fields.Add(numberField);

            PasswordField passwordField = new PasswordField();

            passwordField.Id = Guid.NewGuid();
            passwordField.Name = "Password field";
            passwordField.Label = "Password field";
            passwordField.PlaceholderText = "Password field placeholder text";
            passwordField.Description = "Password field description";
            passwordField.HelpText = "Password field help text";
            passwordField.Required = true;
            passwordField.Unique = true;
            passwordField.Searchable = true;
            passwordField.Auditable = true;
            passwordField.System = true;

            passwordField.MaxLength = 1;
            passwordField.MaskType = Api.PasswordFieldMaskTypes.MaskAllCharacters;
            passwordField.MaskCharacter = '*';

            fields.Add(passwordField);

            PercentField percentField = new PercentField();

            percentField.Id = Guid.NewGuid();
            percentField.Name = "Percent field";
            percentField.Label = "Percent field";
            percentField.PlaceholderText = "Percent field";
            percentField.Description = "Percent field description";
            percentField.HelpText = "Percent field help text";
            percentField.Required = true;
            percentField.Unique = true;
            percentField.Searchable = true;
            percentField.Auditable = true;
            percentField.System = true;
            percentField.DefaultValue = 0;

            percentField.MinValue = 1;
            percentField.MaxValue = 100;
            percentField.DecimalPlaces = 3;

            fields.Add(percentField);

            PhoneField phoneField = new PhoneField();

            phoneField.Id = Guid.NewGuid();
            phoneField.Name = "Phone field";
            phoneField.Label = "Phone field";
            phoneField.PlaceholderText = "Phone field";
            phoneField.Description = "Phone field description";
            phoneField.HelpText = "Phone field help text";
            phoneField.Required = true;
            phoneField.Unique = true;
            phoneField.Searchable = true;
            phoneField.Auditable = true;
            phoneField.System = true;
            phoneField.DefaultValue = "";

            phoneField.Format = "{0000}-{000}-{000}";
            phoneField.MaxLength = 10;

            fields.Add(phoneField);

            PrimaryKeyField primaryKeyField = new PrimaryKeyField();

            primaryKeyField.Id = Guid.NewGuid();
            primaryKeyField.Name = "PrimaryKey field";
            primaryKeyField.Label = "PrimaryKey field";
            primaryKeyField.PlaceholderText = "PrimaryKey field placeholder text";
            primaryKeyField.Description = "PrimaryKey field description";
            primaryKeyField.HelpText = "PrimaryKey field help text";
            primaryKeyField.Required = true;
            primaryKeyField.Unique = true;
            primaryKeyField.Searchable = true;
            primaryKeyField.Auditable = true;
            primaryKeyField.System = true;
            primaryKeyField.DefaultValue = Guid.Empty;

            fields.Add(primaryKeyField);

            SelectField selectField = new SelectField();

            selectField.Id = Guid.NewGuid();
            selectField.Name = "Select field";
            selectField.Label = "Select field";
            selectField.PlaceholderText = "Select field placeholder text";
            selectField.Description = "Select field description";
            selectField.HelpText = "Select field help text";
            selectField.Required = true;
            selectField.Unique = true;
            selectField.Searchable = true;
            selectField.Auditable = true;
            selectField.System = true;
            selectField.DefaultValue = "itemKey2";

            selectField.Options = new Dictionary<string, string>();
            selectField.Options.Add("itemKey1", "itemValue1");
            selectField.Options.Add("itemKey2", "itemValue2");
            selectField.Options.Add("itemKey3", "itemValue3");
            selectField.Options.Add("itemKey4", "itemValue4");
            selectField.Options.Add("itemKey5", "itemValue5");
            selectField.Options.Add("itemKey6", "itemValue6");

            fields.Add(selectField);

            TextField textField = new TextField();

            textField.Id = Guid.NewGuid();
            textField.Name = "Text field";
            textField.Label = "Text field";
            textField.PlaceholderText = "Text field placeholder text";
            textField.Description = "Text field description";
            textField.HelpText = "Text field help text";
            textField.Required = true;
            textField.Unique = true;
            textField.Searchable = true;
            textField.Auditable = true;
            textField.System = true;
            textField.DefaultValue = "";

            textField.MaxLength = 200;

            UrlField urlField = new UrlField();

            urlField.Id = Guid.NewGuid();
            urlField.Name = "Url field";
            urlField.Label = "Url field";
            urlField.PlaceholderText = "Url field placeholder text";
            urlField.Description = "Url field description";
            urlField.HelpText = "Url field help text";
            urlField.Required = true;
            urlField.Unique = true;
            urlField.Searchable = true;
            urlField.Auditable = true;
            urlField.System = true;
            urlField.DefaultValue = "";

            urlField.MaxLength = 200;
            urlField.OpenTargetInNewWindow = true;

            fields.Add(urlField);

            return fields;
        }

        private List<View> CreateTestViewCollection(Entity entity)
        {
            List<View> views = new List<View>();

            View firstView = new View();

            firstView.Id = Guid.NewGuid();
            firstView.Name = "Search Popup view name";
            firstView.Label = "Search Popup view label";
            firstView.Type = Api.ViewTypes.SearchPopup;

            firstView.Filters = new List<ViewFilter>();

            ViewFilter filter = new ViewFilter();
            filter.EntityId = entity.Id;
            filter.FieldId = entity.Fields[1].Id.Value;
            filter.Operator = Api.FilterOperatorTypes.Equals;
            filter.Value = "false";

            firstView.Filters.Add(filter);

            firstView.Fields = new List<ViewField>();

            ViewField field1 = new ViewField();
            field1.EntityId = entity.Id;
            field1.Id = entity.Fields[3].Id.Value;
            field1.Position = 1;

            firstView.Fields.Add(field1);

            ViewField field2 = new ViewField();
            field2.EntityId = entity.Id;
            field2.Id = entity.Fields[10].Id.Value;
            field2.Position = 2;

            firstView.Fields.Add(field2);

            views.Add(firstView);
            return views;
        }

        private List<Form> CreateTestFormCollection(Entity entity)
        {
            List<Form> forms = new List<Form>();

            Form form = new Form();

            form.Id = Guid.NewGuid();
            form.Name = "Form name";
            form.Label = "Form label";

            form.Fields = new List<FormField>();

            FormField field1 = new FormField();

            field1.Id = entity.Fields[1].Id.Value;
            field1.EntityId = entity.Id;
            field1.Column = Api.FormColumns.Left;
            field1.Position = 1;

            form.Fields.Add(field1);

            FormField field2 = new FormField();

            field2.Id = entity.Fields[5].Id.Value;
            field2.EntityId = entity.Id;
            field2.Column = Api.FormColumns.Right;
            field2.Position = 2;

            form.Fields.Add(field2);

            forms.Add(form);

            return forms;
        }
    }
}