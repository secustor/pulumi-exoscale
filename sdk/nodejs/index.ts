// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

// Export members:
export * from "./affinity";
export * from "./antiAffinityGroup";
export * from "./compute";
export * from "./computeInstance";
export * from "./database";
export * from "./domain";
export * from "./domainRecord";
export * from "./elasticIP";
export * from "./getAffinity";
export * from "./getAntiAffinityGroup";
export * from "./getCompute";
export * from "./getComputeIPAddress";
export * from "./getComputeInstance";
export * from "./getComputeTemplate";
export * from "./getDomain";
export * from "./getDomainRecord";
export * from "./getElasticIP";
export * from "./getNLB";
export * from "./getNetwork";
export * from "./getPrivateNetwork";
export * from "./getSecurityGroup";
export * from "./instancePool";
export * from "./ipaddress";
export * from "./network";
export * from "./nic";
export * from "./nlb";
export * from "./nlbservice";
export * from "./privateNetwork";
export * from "./provider";
export * from "./secondaryIPAddress";
export * from "./securityGroup";
export * from "./securityGroupRule";
export * from "./securityGroupRules";
export * from "./skscluster";
export * from "./sksnodePool";
export * from "./sshkey";
export * from "./sshkeyPair";

// Export sub-modules:
import * as config from "./config";
import * as types from "./types";

export {
    config,
    types,
};

// Import resources to register:
import { Affinity } from "./affinity";
import { AntiAffinityGroup } from "./antiAffinityGroup";
import { Compute } from "./compute";
import { ComputeInstance } from "./computeInstance";
import { Database } from "./database";
import { Domain } from "./domain";
import { DomainRecord } from "./domainRecord";
import { ElasticIP } from "./elasticIP";
import { IPAddress } from "./ipaddress";
import { InstancePool } from "./instancePool";
import { NIC } from "./nic";
import { NLB } from "./nlb";
import { NLBService } from "./nlbservice";
import { Network } from "./network";
import { PrivateNetwork } from "./privateNetwork";
import { SKSCluster } from "./skscluster";
import { SKSNodePool } from "./sksnodePool";
import { SSHKey } from "./sshkey";
import { SSHKeyPair } from "./sshkeyPair";
import { SecondaryIPAddress } from "./secondaryIPAddress";
import { SecurityGroup } from "./securityGroup";
import { SecurityGroupRule } from "./securityGroupRule";
import { SecurityGroupRules } from "./securityGroupRules";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "exoscale:index/affinity:Affinity":
                return new Affinity(name, <any>undefined, { urn })
            case "exoscale:index/antiAffinityGroup:AntiAffinityGroup":
                return new AntiAffinityGroup(name, <any>undefined, { urn })
            case "exoscale:index/compute:Compute":
                return new Compute(name, <any>undefined, { urn })
            case "exoscale:index/computeInstance:ComputeInstance":
                return new ComputeInstance(name, <any>undefined, { urn })
            case "exoscale:index/database:Database":
                return new Database(name, <any>undefined, { urn })
            case "exoscale:index/domain:Domain":
                return new Domain(name, <any>undefined, { urn })
            case "exoscale:index/domainRecord:DomainRecord":
                return new DomainRecord(name, <any>undefined, { urn })
            case "exoscale:index/elasticIP:ElasticIP":
                return new ElasticIP(name, <any>undefined, { urn })
            case "exoscale:index/iPAddress:IPAddress":
                return new IPAddress(name, <any>undefined, { urn })
            case "exoscale:index/instancePool:InstancePool":
                return new InstancePool(name, <any>undefined, { urn })
            case "exoscale:index/nIC:NIC":
                return new NIC(name, <any>undefined, { urn })
            case "exoscale:index/nLB:NLB":
                return new NLB(name, <any>undefined, { urn })
            case "exoscale:index/nLBService:NLBService":
                return new NLBService(name, <any>undefined, { urn })
            case "exoscale:index/network:Network":
                return new Network(name, <any>undefined, { urn })
            case "exoscale:index/privateNetwork:PrivateNetwork":
                return new PrivateNetwork(name, <any>undefined, { urn })
            case "exoscale:index/sKSCluster:SKSCluster":
                return new SKSCluster(name, <any>undefined, { urn })
            case "exoscale:index/sKSNodePool:SKSNodePool":
                return new SKSNodePool(name, <any>undefined, { urn })
            case "exoscale:index/sSHKey:SSHKey":
                return new SSHKey(name, <any>undefined, { urn })
            case "exoscale:index/sSHKeyPair:SSHKeyPair":
                return new SSHKeyPair(name, <any>undefined, { urn })
            case "exoscale:index/secondaryIPAddress:SecondaryIPAddress":
                return new SecondaryIPAddress(name, <any>undefined, { urn })
            case "exoscale:index/securityGroup:SecurityGroup":
                return new SecurityGroup(name, <any>undefined, { urn })
            case "exoscale:index/securityGroupRule:SecurityGroupRule":
                return new SecurityGroupRule(name, <any>undefined, { urn })
            case "exoscale:index/securityGroupRules:SecurityGroupRules":
                return new SecurityGroupRules(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("exoscale", "index/affinity", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/antiAffinityGroup", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/compute", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/computeInstance", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/database", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/domain", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/domainRecord", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/elasticIP", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/iPAddress", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/instancePool", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/nIC", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/nLB", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/nLBService", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/network", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/privateNetwork", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/sKSCluster", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/sKSNodePool", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/sSHKey", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/sSHKeyPair", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/secondaryIPAddress", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/securityGroup", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/securityGroupRule", _module)
pulumi.runtime.registerResourceModule("exoscale", "index/securityGroupRules", _module)

import { Provider } from "./provider";

pulumi.runtime.registerResourcePackage("exoscale", {
    version: utilities.getVersion(),
    constructProvider: (name: string, type: string, urn: string): pulumi.ProviderResource => {
        if (type !== "pulumi:providers:exoscale") {
            throw new Error(`unknown provider type ${type}`);
        }
        return new Provider(name, <any>undefined, { urn });
    },
});