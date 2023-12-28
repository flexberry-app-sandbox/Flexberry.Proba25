import EditFormController from 'ember-flexberry/controllers/edit-form';

export default EditFormController.extend({
  parentRoute: 'i-i-s-proba2-рег-результ-l',

  getCellComponent(attr, bindingPath, model) {
    let cellComponent = this._super(...arguments);
    if (attr.kind === 'belongsTo') {
      switch (`${model.modelName}+${bindingPath}`) {
        case 'i-i-s-proba2-т-ч-рег-результ+сотрудники':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'фИОСотр',
            required: true,
            relationName: 'сотрудники',
            projection: 'СотрудникиL',
            autocomplete: true,
          };
          break;

      }
    }

    return cellComponent;
  },
});
