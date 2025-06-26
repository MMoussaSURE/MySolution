import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'MySolution',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44385/',
    redirectUri: baseUrl,
    clientId: 'MySolution_App',
    responseType: 'code',
    scope: 'offline_access MySolution',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44385',
      rootNamespace: 'MySolution',
    },
  },
} as Environment;
