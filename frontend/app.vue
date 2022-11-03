<template>
	<n-message-provider>
		<NuxtLayout>
			<NuxtPage />
		</NuxtLayout>
	</n-message-provider>
</template>

<script lang="ts">
import { NMessageProvider } from 'naive-ui';
export default {
	components: {
		NMessageProvider,
	},
};
</script>
