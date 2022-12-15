<template>
  <div><h1>test</h1></div>
</template>

<script>
import Container from "./Container";
import MatchedCard from "./MatchedCard";
import {NButton, NCard, NSpace} from "naive-ui";

export default {
  name: "MatchedInterns",
  components: {Container, NButton, NSpace, NCard, MatchedCard},
  props: {
    website: String,
    streetadress: String,
  }
}
</script>

<style scoped>

.grid-container {
  display: grid;
  grid-template-columns: 1fr 1fr;
  grid-gap: 20px;
}
</style>