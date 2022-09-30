<template>
  <container>
    <student-landing-page-header/>
    <student-landing-page-services/>
  </container>
</template>
<script>

import StudentLandingPageHeader from "../components/StudentLandingPageHeader";
import StudentLandingPageServices from "../components/StudentLandingPageServices";

export default {
  components: {
    StudentLandingPageServices,
    StudentLandingPageHeader,
  }
}
</script>