<template>
  <n-card :bordered="false" class="matched-container" hoverable
  >
    <ellipsis-vertical size="20" class="field-header__person-icon"/>
    <h1 class="internshipText">
      {{ this.internship.name }}
    </h1>
    <p class="cityText">
      {{ this.internship.city }}
    </p>
    <br>
    <div>
      <n-tag class="tag">Marketing</n-tag>
      <n-tag class="tag">Advertising</n-tag>
    </div>
    <br>
    <div class="tutoring-container">
      <person-sharp size="20" class="field-header__person-icon"/>
      <p>Gemiddelde begeleiding</p>
    </div>
    <br>
    <li v-for="(item) in items">
      {{ item.message }}
    </li>
    <br>
    <p class="lastPostedText">
      15 dagen geleden geplaatst
    </p>
  </n-card>
</template>

<script>
import {PersonSharp, EllipsisVertical} from "@vicons/ionicons5";
import {NTag, NCard} from "naive-ui";

export default {
  components: {
    PersonSharp,
    EllipsisVertical,
    NTag,
    NCard,
  },
  props: {
    internship: {}
  },
  name: "MatchedCard",
  data() {
    return {
      currentHighlightedInternship: "",
      items: [
        {message: 'Leuke stage'},
        {message: 'Veel leermogelijkheden'}
      ],
    }
  },
}
</script>
<style scoped>
.internshipText {
  font-size: 32px;
  font-weight: bolder;
  padding: 0;
  margin: 0;
  line-height: 1;
}
.lastPostedText {
  color:grey;
}
.cityText {
  color: grey;
  font-size: 14px;
  padding: 0;
  margin:0;
}
.tag {
  color: grey;
}
.tutoring-container{
  display:flex;
  flex-direction: row;
}
.field-header__person-icon {
  height: 20px;
  float: right
}

.matched-container:hover {
  border: 1.5px solid black;
}
</style>