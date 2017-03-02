import Vue from "vue";

import CurrentTime from "./components/CurrentTime.vue";

const app = new Vue({
    el: "#vue-root",
    components: { CurrentTime },
    data: {
        header: "Vue is awesome!"
    }
});