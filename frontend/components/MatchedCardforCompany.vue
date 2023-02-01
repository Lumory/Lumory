<!-- child component for all matched interns for a company (internship company) -->
<template>
  <n-card :bordered="false" class="matched-container" hoverable content-style="display: flex; flex-direction: column; gap: 15px">
    <div>
      <n-space justify="space-between" item-style="max-width: 50%" style="flex-wrap: nowrap">
        <h3 class="card-title">{{ this.intern.function }}</h3>
        <ellipsis-vertical size="20" class="card-options-icon"/>
      </n-space>
      <p class="city-text">{{this.intern.streetAddress}}, {{ this.intern.city }}</p>
    </div>
    <n-space>
      <n-tag class="tag" v-for="skill in this.intern.skillsToLearnIntern.split(',')">{{ skill }}</n-tag>
    </n-space>
    <div class="card-content">
      <p><span style="font-weight: bold">Probleem:</span> {{ this.intern?.problem }}</p>
      <p><span style="font-weight: bold">Sector:</span> {{ this.intern?.sector }}</p>
      <p><span style="font-weight: bold">Begeleiding:</span> {{ this.intern?.mentorship }}</p>
      <p><span style="font-weight: bold">Vergoeding:</span> {{ this.intern?.money }}</p>
    </div>
    <p class="last-posted-text">Geplaatst op {{ new Date(this.intern?.createdAt).toLocaleDateString() }}</p>
  </n-card>
</template>

<script>
import {PersonSharp, EllipsisVertical} from "@vicons/ionicons5";
import {NTag, NCard, NSpace, NGrid} from "naive-ui";

export default {
  components: {
    PersonSharp,
    EllipsisVertical,
    NTag,
    NCard,
    NSpace,
    NGrid
  },
  name: "MatchedCardForCompany",

  // object
  props: {
    intern: ''
  },
}
</script>
<style scoped>
.card-title {
  font-size: 32px;
  font-weight: bolder;
  padding: 0;
  margin: 0;
  line-height: 1;
}

.last-posted-text {
  color: grey;
}

.city-text {
  color: grey;
  font-size: 14px;
  padding: 0;
  margin: 0;
}

.tag {
  color: grey;
}

.card-options-icon {
  height: 20px;
}

.matched-container {
  height: 100%;
}

.matched-container:hover {
  outline: 1px solid black;
  outline-offset: -1px;
}

.tutoring-container {
  display: flex;
  flex-direction: row;
  margin-top: 15px;
  margin-bottom: 15px;
}
</style>
