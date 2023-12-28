import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  тЧГрафСобес: DS.hasMany('i-i-s-proba2-т-ч-граф-собес', { inverse: 'графСобес', async: false })
});

export let ValidationRules = {
  тЧГрафСобес: {
    descriptionKey: 'models.i-i-s-proba2-граф-собес.validations.тЧГрафСобес.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ГрафСобесE', 'i-i-s-proba2-граф-собес', {
    тЧГрафСобес: hasMany('i-i-s-proba2-т-ч-граф-собес', 'Т ч граф собес', {
      планирСобес: belongsTo('i-i-s-proba2-планир-собес', 'Дата план собес', {
        время: attr('Время', { index: 1 }),
        иметьПриСебе: attr('Иметь при себе', { index: 2, hidden: true }),
        регистАнкеты: belongsTo('i-i-s-proba2-регист-анкеты', '', {
          фИОКандид: attr('ФИО', { index: 3 }),
          вакантДолжн: belongsTo('i-i-s-proba2-вакант-должн', '', {
            должность: attr('Вакантная должность', { index: 4 })
          }, { index: -1, hidden: true })
        }, { index: -1, hidden: true })
      }, { index: 0, displayMemberPath: 'датаПланСобес' })
    })
  });

  modelClass.defineProjection('ГрафСобесL', 'i-i-s-proba2-граф-собес', {
    
  });
};
