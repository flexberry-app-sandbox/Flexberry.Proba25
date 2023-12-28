import EditFormController from 'ember-flexberry/controllers/edit-form';

export default EditFormController.extend({
  parentRoute: 'i-i-s-proba2-граф-собес-l',

  getCellComponent(attr, bindingPath, model) {
    let cellComponent = this._super(...arguments);
    if (attr.kind === 'belongsTo') {
      switch (`${model.modelName}+${bindingPath}`) {
        case 'i-i-s-proba2-т-ч-граф-собес+планирСобес':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'датаПланСобес',
            required: true,
            relationName: 'планирСобес',
            projection: 'ПланирСобесL',
            autocomplete: true,
          };
          break;

      }
    }

    return cellComponent;
  },
});
