<template>
    <table class="table table-bordered">
        <thead>
            <tr>
                <th>Id</th>
                <th style="width:30%">Name</th>
                <th style="width:15%">Inventory</th>
                <th style="width:15%">Price</th>
                <th>Last Updated</th>
            </tr>
        </thead>
        <tbody>
            <tr v-if="loading">
                <td colspan="5" class="loading">Loading...</td>
            </tr>
            <tr v-for="product in products" key="product.id">
                <td v-text="product.id"></td>
                <td v-text="product.name"></td>
                <td v-text="product.inventory" :class="{ 'low-inventory' : product.inventory < 20 }"></td>
                <td>{{ product.price | formatCurrency }}</td>
                <td>{{ product.lastUpdated | timeAgo }}</td>
            </tr>
        </tbody>
    </table>
</template>

<script>
    import moment from "moment";
    import numeral from "numeral";
    
    export default {
        props: ["loading", "products"],
        filters: {
            timeAgo (value) {
                return moment.utc(value).fromNow();
            },
            formatCurrency (value) {
                return numeral(value).format("$0,0.00");
            }
        }
    }

</script>

<style lang="scss" scoped>
    .low-inventory {
        background-color: #fff9db;
        color: #d9480f;
    }
    .loading {
        color: #2f9e44;
    }
</style>