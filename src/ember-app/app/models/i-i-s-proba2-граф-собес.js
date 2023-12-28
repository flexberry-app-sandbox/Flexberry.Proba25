import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as ГрафСобесMixin
} from '../mixins/regenerated/models/i-i-s-proba2-граф-собес';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(ГрафСобесMixin, Validations, {
});

defineProjections(Model);

export default Model;
