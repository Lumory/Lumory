<template>
  <n-space class="services-section">
    <h1>Wat bieden wij?</h1>
    <n-grid cols="1 s:3" x-gap="25px" responsive="screen">
      <n-grid-item class="n-grid-item">
          <n-icon size="48">
            <pin-drop-outlined />
          </n-icon>
        <h3>Lorum Ipsum</h3>
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus velit eros, facilisis suscipit risus sed, venenatis rutrum lectus.</p>
      </n-grid-item>
      <n-grid-item class="n-grid-item">
        <n-icon size="48">
          <pin-drop-outlined />
        </n-icon>
        <h3>Lorum Ipsum</h3>
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus velit eros, facilisis suscipit risus sed, venenatis rutrum lectus.</p>
      </n-grid-item>
      <n-grid-item class="n-grid-item">
        <n-icon size="48">
          <pin-drop-outlined />
        </n-icon>
        <h3>Lorum Ipsum</h3>
        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus velit eros, facilisis suscipit risus sed, venenatis rutrum lectus.</p>
      </n-grid-item>
    </n-grid>
  </n-space>
</template>

<script>
import {NGrid, NGridItem, NIcon, NSpace} from "naive-ui";
import {PinDropOutlined} from "@vicons/material";

export default {
  components: {
    NGrid,
    NGridItem,
    PinDropOutlined,
    NIcon,
    NSpace
  }
}
</script>

<style scoped>
.services-section {
  display: block;
  width: 80%;
  margin: 100px auto 0 auto;
}
h1 {
  text-align: center;
  display: block;
  font-weight: bold;
}
.n-grid-item {
  text-align: center;
  margin-bottom: 50px;
}

@media (min-width: 640px) {
  .services-section {
    width: 100%;
  }
  .n-grid {
    width: 100%;
  }
}
</style>