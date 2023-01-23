<template>
  <h1>
    test
    {{data?.problemDescription}}
 </h1>
</template>

<script>
import getService from "../../services/InternshipService";

export default {
  async setup() {
    const route = useRoute()
    const data = await getService.getInternship(route.params.id)
    console.log(data)
    return data

  },
  name: "s"
}
</script>

<style scoped>

</style>

