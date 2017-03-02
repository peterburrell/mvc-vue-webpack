<template>
    <div>
        <h1 v-text="header"></h1>
        <div class="row">
            <div class="col-lg-8">
                <products-table :products="products" :loading="loading"></products-table>
            </div>
        </div>
    </div>
</template>

<script>
    import axios from "axios";
    import ProductsTable from "./ProductsTable.vue";

    export default {
        components: {
            ProductsTable
        },
        data() {
            return {
                header: "Products",
                loading: false,
                products: []
            };
        },
        created() {
            this.fetchData();
        },
        methods: {
            fetchData() {
                this.loading = true;
                
                axios.get("/api/products")
                    .then(response => {
                        this.products = response.data;
                        this.loading = false;
                    })
                    .catch(error => {
                        this.loading = false;
                        console.log(error);
                    });
            }
        }
    }
</script>

<style lang="scss" scoped>
    $cyan: #22b8cf;

    h1 {
        color: $cyan;
    }
</style>