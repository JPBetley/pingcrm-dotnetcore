import { createApp, h } from 'vue'
import { createInertiaApp } from '@inertiajs/inertia-vue3'
// import VueMeta from 'vue-meta'
// import PortalVue from 'portal-vue'
import { InertiaProgress } from '@inertiajs/progress'

Vue.config.productionTip = false
// Vue.mixin({ methods: { route: window.route } })
// Vue.use(PortalVue)
// Vue.use(VueMeta)

InertiaProgress.init()

createInertiaApp({
  resolve: name => require(`./Pages/${name}`),
  setup({ el, app, props }) {
    new Vue({
      metaInfo: {
        titleTemplate: title => (title ? `${title} - Ping CRM` : 'Ping CRM'),
      },
      render: h => h(app, props),
    }).$mount(el)
  },
})


createInertiaApp({
  resolve: name => require(`./Pages/${name}`),
  setup({ el, app, props, plugin }) {
    createApp({ render: () => h(app, props) })
      .use(plugin)
      .mount(el)
  },
})