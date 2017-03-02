<template>
    <h1 class="current-time">The current date/time is {{ currentTime }}.</h1>
</template>

<script>
    import moment from "moment";

    export default {
        computed: {
            currentTime() {
                return moment().format("dddd, MMMM Do YYYY, h:mm:ss a");
            }
        }
    }
</script>

<style lang="scss">
    $pink: #f06595;

    .current-time {
        color: $pink;
    }

</style>