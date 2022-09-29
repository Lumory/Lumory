<template>
  <container>
    <n-grid v-bind:cols="2" x-gap="25px">
      <n-grid-item>
        <n-layout>
          <n-layout-content>
            <p class="intro-text">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus velit eros, facilisis suscipit risus sed, venenatis rutrum lectus.</p>
            <n-button round color="#FEBF00">Sign up</n-button>
          </n-layout-content>
        </n-layout>
      </n-grid-item>
      <n-grid-item>
        <n-image
            width="100"
            src="https://07akioni.oss-cn-beijing.aliyuncs.com/07akioni.jpeg"
        />
      </n-grid-item>
    </n-grid>
  </container>
</template>

<script>
import {NGrid, NGridItem, NLayout, NLayoutContent, NButton, NImage} from "naive-ui";

export default {
  components: {
    NGrid,
    NGridItem,
    NLayout,
    NLayoutContent,
    NButton,
    NImage
  }
}
</script>

<style>
.intro-text {
  font-family: "Arial";
  font-weight: bold;
  font-size: 24px;
  line-height: 1.2em;
}
</style>