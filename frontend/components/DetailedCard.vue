<!-- child component showing clicked intern card with more detail -->

<template>
  <n-space vertical>
    <!-- Titel of matched interns in Lumory Container -->
    <n-card>
      <template #header>
        <n-space class="card-title">
          {{ internship?.problem }}
        </n-space>
        <n-space class="card-city">
          {{ internship?.city }}
        </n-space>
      </template>
      <n-space>
        <n-tag class="tag">Marketing</n-tag>
        <n-tag class="tag">Advertising</n-tag>
      </n-space>
      <template class="tutoring-container">
        <n-space>
          <person-sharp size="20" class="field-header__person-icon"/>
          <n-space class="tutoring">Gemiddelde begeleiding</n-space>
        </n-space>
      </template>
      <n-space style="font-weight: bolder">
        Volledige Vacaturetekst
      </n-space>
      <n-space class="description-text">
        {{ this.internship?.problemDescription }}
      </n-space>
    </n-card>
  </n-space>
</template>

<script>
import {PersonSharp} from "@vicons/ionicons5";
import {NCard, NTag, NSpace} from "naive-ui";

export default {
  components: {
    PersonSharp,
    NCard,
    NTag,
    NSpace
  },
  name: "DetailedCard",
  matchedresults: [],
  props: {
    internship: {}
  },
}
</script>
<style scoped>


.field-header__person-icon {
  height: 20px;
}

.card-title {
  font-weight: 800;
  font-size: 32px;
  line-height: 1;
}

.description-text {
  font-size: 14px;
}

.card-city {
  color: grey;
  font-size: 14px;
}

.tag {
  color: grey;
}

.tutoring-container {
  display: flex;
  flex-direction: row;
  margin-top: 15px;
  margin-bottom: 15px;
}
</style>
