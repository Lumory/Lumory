<template>
  <n-card>
    <n-space style="font-weight: bolder; font-size: 24px">
      Geïnteresseerden
    </n-space>
  <n-data-table
      :columns="columns"
      :data="stagiaires"
      :row-key="rowKey"
      @update:checked-row-keys="handleCheck"
  />
  </n-card>
</template>

<script>
import {NDataTable, NButton, NSpace,NCard} from "naive-ui";
import userService from "../services/UserService";
const createColumns = ({ play }) => {
  return [
    {
      title: "Naam",
      key: "firstName",
      resizable: true,
    },
    {
      title: "Gebruikerstype",
      key: "userType",
      resizable: true,
    },
    {
      title: "Gereageerd op",
      key: "updatedAt",
      resizable: true,
      minWidth: 50,
      maxWidth: 100,
    },
    {
      title: "Status",
      key: "status",
      render() {
        return h(
            NButton,
            {
              strong: true,
              tertiary: true,
              size: "small",
            },
            { default: () => "Weet ik veel" }
        );
      },
    },
  ];
};

export default {
  data() {
    return {
      stagiaires: [{
        firstName: '',
        userType: '',
        updatedAt: []

      }],
      columns: createColumns({
        play(row) {
          message.info(`Play ${row.title}`);
        },
      }),
      pagination: false,
    };
  },
  name: "geintereseerdeStagiaires",
  components: {
    NDataTable,
    NSpace,
    NCard
  },
  mounted: function () {
    userService.getAllUsers().then(response => {
      this.stagiaires = response
      console.log(response)
    })
  }
}
</script>

<style scoped>

</style>