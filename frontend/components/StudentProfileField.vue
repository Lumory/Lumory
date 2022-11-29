<template>
	<div class="field">
		<div class="field-header">
			<h3 class="field-header__title">{{ title }}</h3>
			<n-dropdown trigger="click" :options="options" @select="handleSelect" >
				<ellipsis-vertical class="field-header__options-icon"></ellipsis-vertical>
			</n-dropdown>
		</div>
		<slot />
	</div>
</template>

<script lang="ts">
import { EllipsisVertical } from "@vicons/ionicons5";
import { useMessage, NDropdown } from "naive-ui";
export default {
	components: {
		EllipsisVertical,
		NDropdown
	},
	props: {
		title: String,
	},
	setup() {
		const message = useMessage();
		return {
			options: [
				{
					label: 'edit',
					key: 'edit',
				}
			],
			handleSelect(key: string | number) {
				message.info(String(key))
			}
		}
	}
}
</script>

<style scoped>
.field {
	background-color: var(--color-white);
	border-radius: 3px;
	-webkit-box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05); 
	box-shadow: 0px 2px 2px 0px rgba(0,0,0,0.05);
	padding: 25px;
}
.field-header {
	display: flex;
	align-items: center;
	justify-content: space-between;
	padding-bottom: 20px;
}
.field-header__title {
	padding: 0;
}
.field-header__options-icon {
	height: 20px;
}
.field-header__options-icon:hover {
	cursor: pointer;
}
</style>