<template>
  <Container>
      <n-tabs default-value="Stage details" type="line">
        <n-tab-pane name="Stage details" tab="Stage details">
          <n-scrollbar class="scroll" style="max-height: 700px; padding-right:15px" trigger="none">
          <n-grid :x-gap="12" cols="4" item-responsive>
            <n-grid-item span="0 400:1 600:2 800:3">
              <VolledigeVacature/>
            </n-grid-item>
            <n-grid-item>
              <n-card title="Basis">
                <n-space class="descriptionText" style="font-weight: bolder">
                  Naam opleiding
                </n-space>
                <n-space class="descriptionText" style="font-weight: bolder">
                  Leerjaar
                </n-space>
              </n-card>
            </n-grid-item>
          </n-grid>
          </n-scrollbar>
        </n-tab-pane>
        <n-tab-pane name="Stagiaires" tab="Stagiaires">
          <stagesGeintereseerdeStagiaires/>
        </n-tab-pane>
      </n-tabs>
  </Container>
</template>

<script>
import getService from "../../services/InternshipService";
import {NCard, NTabs, NTabPane, NScrollbar, NGrid, NGridItem, NSpace, useMessage} from "naive-ui"
import internshipService from "../../services/InternshipService";
export default {
  data() {
    return {
      message: useMessage(),
      stages: ''
    }
  },
  components: {
    NCard,
    NTabs,
    NTabPane,
    NScrollbar,
    NGrid,
    NGridItem,
    NSpace
  },
  mounted: async function () {
    const message = useMessage()
    const route = useRoute()
    await internshipService.getInternship(route.params.id).then(response => {
      this.stages = response
    }).catch(error => {
      if (error.response.status === 404) {
        message.error('Geen internetverbinding')
      } else {
        message.error('Neem contact op met Lumory')
      }
    })
  },
  name: "s"
}
</script>

<style scoped>
.field-header__person-icon {
  height: 20px;
}

.cardTitle {
  font-weight: 800;
  font-size: 32px;
  line-height: 1;
}

.descriptionText {
  font-weight: bold;
  font-size: 14px;
}

</style>

