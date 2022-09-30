<template>
  <container>
    <student-landing-page-header/>
    <student-landing-page-services/>
    <student-landing-page-partners/>
  </container>
</template>
<script>

import StudentLandingPageHeader from "../components/StudentLandingPageHeader";
import StudentLandingPageServices from "../components/StudentLandingPageServices";
import StudentLandingPagePartners from "../components/StudentLandingPagePartners";

export default {
  components: {
    StudentLandingPagePartners,
    StudentLandingPageServices,
    StudentLandingPageHeader,
  }
}
</script>