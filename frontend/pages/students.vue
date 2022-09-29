<template>
  <div>
    <the-navbar/>
    <h1>Welcome to students</h1>
    <student-landing-page-header/>
  </div>
</template>
<script>

import TheNavbar from "../components/TheNavbar";
import StudentLandingPageHeader from "../components/StudentLandingPageHeader";

export default {
  components: {
    StudentLandingPageHeader,
    TheNavbar
  }
}
</script>