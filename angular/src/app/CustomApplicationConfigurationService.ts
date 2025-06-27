import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';
import { ApplicationConfigurationDto, ApplicationConfigurationRequestOptions } from '@abp/ng.core';

@Injectable()
export class CustomApplicationConfigurationService {
	apiName = 'abp';

	constructor(private restService: RestService) { }

	get = (
		options: ApplicationConfigurationRequestOptions,
		config?: Partial<import('@abp/ng.core').Rest.Config>
	) => {
		var language = 'ar';

		var cookieName = '.AspNetCore.Culture';
		var match = document.cookie.match(new RegExp('(^| )' + cookieName + '=([^;]+)'));
		if (match) {
			var cultureCookie = match[2];
			if (cultureCookie) {
				try {
					var decoded = decodeURIComponent(cultureCookie); // c=en|uic=en
					var parts = decoded.split('|');
					language = parts[0].split('=')[1]; // get the language part
				} catch (e) {
					console.warn('Failed to parse culture cookie', e);
				}
			}
		}

		var headers: { [name: string]: string } = {};
		if (language) {
			headers['Accept-Language'] = language;
		}
		return this.restService.request<any, ApplicationConfigurationDto>(
			{
				method: 'GET',
				url: '/api/abp/application-configuration',
				params: {
					includeLocalizationResources: options.includeLocalizationResources,
				},
				headers: headers,
			},
			{ apiName: this.apiName, ...config }
		);
	};
}
