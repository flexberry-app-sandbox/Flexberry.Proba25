import {
  defineNamespace,
  defineProjections,
  Model as ТЧРегРезультMixin
} from '../mixins/regenerated/models/i-i-s-proba2-т-ч-рег-результ';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ТЧРегРезультMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
