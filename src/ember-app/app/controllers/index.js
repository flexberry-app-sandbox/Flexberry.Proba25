import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.информация-об-организации.caption'),
          title: i18n.t('forms.application.sitemap.информация-об-организации.title'),
          children: [{
            link: 'i-i-s-proba2-организация-l',
            caption: i18n.t('forms.application.sitemap.информация-об-организации.i-i-s-proba2-организация-l.caption'),
            title: i18n.t('forms.application.sitemap.информация-об-организации.i-i-s-proba2-организация-l.title'),
            icon: 'file',
            children: null
          }, {
            link: 'i-i-s-proba2-вакант-должн-l',
            caption: i18n.t('forms.application.sitemap.информация-об-организации.i-i-s-proba2-вакант-должн-l.caption'),
            title: i18n.t('forms.application.sitemap.информация-об-организации.i-i-s-proba2-вакант-должн-l.title'),
            icon: 'book',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.документы.caption'),
          title: i18n.t('forms.application.sitemap.документы.title'),
          children: [{
            link: 'i-i-s-proba2-граф-собес-l',
            caption: i18n.t('forms.application.sitemap.документы.i-i-s-proba2-граф-собес-l.caption'),
            title: i18n.t('forms.application.sitemap.документы.i-i-s-proba2-граф-собес-l.title'),
            icon: 'tags',
            children: null
          }, {
            link: 'i-i-s-proba2-рег-результ-l',
            caption: i18n.t('forms.application.sitemap.документы.i-i-s-proba2-рег-результ-l.caption'),
            title: i18n.t('forms.application.sitemap.документы.i-i-s-proba2-рег-результ-l.title'),
            icon: 'chart bar',
            children: null
          }, {
            link: 'i-i-s-proba2-планир-собес-l',
            caption: i18n.t('forms.application.sitemap.документы.i-i-s-proba2-планир-собес-l.caption'),
            title: i18n.t('forms.application.sitemap.документы.i-i-s-proba2-планир-собес-l.title'),
            icon: 'table',
            children: null
          }, {
            link: 'i-i-s-proba2-регист-анкеты-l',
            caption: i18n.t('forms.application.sitemap.документы.i-i-s-proba2-регист-анкеты-l.caption'),
            title: i18n.t('forms.application.sitemap.документы.i-i-s-proba2-регист-анкеты-l.title'),
            icon: 'folder open',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.информация-о-сотрудниках.caption'),
          title: i18n.t('forms.application.sitemap.информация-о-сотрудниках.title'),
          children: [{
            link: 'i-i-s-proba2-сотрудники-l',
            caption: i18n.t('forms.application.sitemap.информация-о-сотрудниках.i-i-s-proba2-сотрудники-l.caption'),
            title: i18n.t('forms.application.sitemap.информация-о-сотрудниках.i-i-s-proba2-сотрудники-l.title'),
            icon: 'briefcase',
            children: null
          }]
        }
      ]
    };
  }),
})