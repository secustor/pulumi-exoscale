// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

declare var exports: any;
const __config = new pulumi.Config("exoscale");

/**
 * Exoscale CloudStack API endpoint (by default: https://api.exoscale.com/v1)
 */
export declare const computeEndpoint: string | undefined;
Object.defineProperty(exports, "computeEndpoint", {
    get() {
        return __config.get("computeEndpoint");
    },
    enumerable: true,
});

/**
 * CloudStack ini configuration filename (by default: cloudstack.ini)
 */
export declare const config: string | undefined;
Object.defineProperty(exports, "config", {
    get() {
        return __config.get("config");
    },
    enumerable: true,
});

export declare const delay: number | undefined;
Object.defineProperty(exports, "delay", {
    get() {
        return __config.getObject<number>("delay");
    },
    enumerable: true,
});

/**
 * Exoscale DNS API endpoint (by default: https://api.exoscale.com/dns)
 */
export declare const dnsEndpoint: string | undefined;
Object.defineProperty(exports, "dnsEndpoint", {
    get() {
        return __config.get("dnsEndpoint");
    },
    enumerable: true,
});

export declare const environment: string | undefined;
Object.defineProperty(exports, "environment", {
    get() {
        return __config.get("environment");
    },
    enumerable: true,
});

/**
 * Defines if the user-data of compute instances should be gzipped (by default: true)
 */
export declare const gzipUserData: boolean | undefined;
Object.defineProperty(exports, "gzipUserData", {
    get() {
        return __config.getObject<boolean>("gzipUserData");
    },
    enumerable: true,
});

/**
 * Exoscale API key
 */
export declare const key: string | undefined;
Object.defineProperty(exports, "key", {
    get() {
        return __config.get("key");
    },
    enumerable: true,
});

export declare const profile: string | undefined;
Object.defineProperty(exports, "profile", {
    get() {
        return __config.get("profile");
    },
    enumerable: true,
});

/**
 * CloudStack ini configuration section name (by default: cloudstack)
 */
export declare const region: string | undefined;
Object.defineProperty(exports, "region", {
    get() {
        return __config.get("region");
    },
    enumerable: true,
});

/**
 * Exoscale API secret
 */
export declare const secret: string | undefined;
Object.defineProperty(exports, "secret", {
    get() {
        return __config.get("secret");
    },
    enumerable: true,
});

/**
 * Timeout in seconds for waiting on compute resources to become available (by default: 300)
 */
export declare const timeout: number | undefined;
Object.defineProperty(exports, "timeout", {
    get() {
        return __config.getObject<number>("timeout");
    },
    enumerable: true,
});

export declare const token: string | undefined;
Object.defineProperty(exports, "token", {
    get() {
        return __config.get("token");
    },
    enumerable: true,
});

