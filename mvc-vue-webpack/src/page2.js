import Vue from "vue";

const app = new Vue({
    template: `<h1>{{ header }}</h1>`,
    data: {
        header: "Page 2 (from Vue)"
    }
});

app.$mount("#vue-root");