<template #description>
  <n-card :bordered="false" class="matched-container" hoverable
  >
    <ellipsis-vertical style="float: right" size="20" class="field-header__options-icon"/>
    <h1 style="font-size: 32px; font-weight: bolder; padding: 0;  margin: 0;">
      {{ this.internship.name }}
    </h1>
    <p style="color: grey; font-size: 14px; padding: 0; margin:0; line-height: 1;">
      {{ this.internship.city }}
    </p>
    <br>
    <n-tag style="margin-right: 15px; color: grey">Marketing</n-tag>
    <n-tag style="color: grey">Advertising</n-tag>
    <br>
    <br>
    <div class="tutoring-container" style="display:flex; flex-direction: row">
      <person-sharp size="20" class="field-header__options-icon"/>
      <p>Gemiddelde begeleiding</p>
    </div>
    <br>
    <li v-for="(item, index) in items">
      {{ item.message }}
    </li>
    <br>
    <p style="color:grey">
      15 dagen geleden geplaatst
    </p>
  </n-card>
</template>

<script>
import Container from "./Container";
import {PersonSharp, EllipsisVertical} from "@vicons/ionicons5";
import {NTag, NCard, NIcon} from "naive-ui";
import axios from "axios"

export default {
  components: {
    PersonSharp,
    EllipsisVertical,
    NTag,
    NCard,
    NIcon,
  },
  props: {
    internship: {}
  },
  name: "MatchedCard",
  data() {
    return {
      items: [
        {message: 'Leuke stage'},
        {message: 'Veel leermogelijkheden'}
      ],
      currentHighlightedInternship: ""
    }
  },
  methods: {
    cardClick(index) {
      this.currentHighlightedInternship = index
    }
  }
}
</script>
<style scoped>
.field-header__options-icon {
  height: 20px;
}

.matched-container:hover {
  border: 1.5px solid black;
}

</style>