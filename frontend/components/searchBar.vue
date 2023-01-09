<template>
  <n-input @keyup="onChange" @change="onChange" v-model="searchCards" type="text" placeholder="Zoeken..." style="max-width: 25%"/>
</template>

<script>
import {NInput} from "naive-ui";
export default {
  computed: {},
  data() {
    return {
      searchText: ''
    }
  },
  name: "searchBar",
  components: {
    NInput
  },
  methods: {
    onChange() {
      this.$emit("search", this.searchText)
    }
  }
}
</script>

<style scoped>

</style>