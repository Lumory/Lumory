<template>
  <client-only>
    <n-menu
        v-model:value="activeKey"
        mode="horizontal"
        v-bind:options="menuOptions"
    />
  </client-only>
</template>

<script lang="ts">

import { NMenu } from 'naive-ui'
import type { MenuOption } from 'naive-ui'
import {RouterLink} from "vue-router";

const menuOptions: MenuOption[] =[
  {
    label: () =>
        h(
            RouterLink,
            {
              to: {
                name: 'index'
              }
            },
            { default: () => 'Go Home' }
        )
    ,
    key: 'hello',
  },
  {
    label: () =>
        h(
            RouterLink,
            {
              to: {
                name: 'students'
              }
            },
            { default: () => 'Go to students' }
        )
    ,
    key: 'students',
  },
]

export default {
  setup() {
    return {
      activeKey: ref<string | null>(null),
      menuOptions
    }
  },
  components: {
    NMenu
  }
}

</script>