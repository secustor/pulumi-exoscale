# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from . import _utilities
import typing
# Export this package's modules as members:
from .affinity import *
from .anti_affinity_group import *
from .compute import *
from .compute_instance import *
from .database import *
from .domain import *
from .domain_record import *
from .elastic_ip import *
from .get_affinity import *
from .get_anti_affinity_group import *
from .get_compute import *
from .get_compute_instance import *
from .get_compute_ip_address import *
from .get_compute_template import *
from .get_domain import *
from .get_domain_record import *
from .get_elastic_ip import *
from .get_network import *
from .get_nlb import *
from .get_private_network import *
from .get_security_group import *
from .instance_pool import *
from .ip_address import *
from .network import *
from .nic import *
from .nlb import *
from .nlb_service import *
from .private_network import *
from .provider import *
from .secondary_ip_address import *
from .security_group import *
from .security_group_rule import *
from .security_group_rules import *
from .sks_cluster import *
from .sks_node_pool import *
from .ssh_key import *
from .ssh_key_pair import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_exoscale.config as __config
    config = __config
else:
    config = _utilities.lazy_import('pulumi_exoscale.config')

_utilities.register(
    resource_modules="""
[
 {
  "pkg": "exoscale",
  "mod": "index/affinity",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/affinity:Affinity": "Affinity"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/antiAffinityGroup",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/antiAffinityGroup:AntiAffinityGroup": "AntiAffinityGroup"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/compute",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/compute:Compute": "Compute"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/computeInstance",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/computeInstance:ComputeInstance": "ComputeInstance"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/database",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/database:Database": "Database"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/domain",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/domain:Domain": "Domain"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/domainRecord",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/domainRecord:DomainRecord": "DomainRecord"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/elasticIP",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/elasticIP:ElasticIP": "ElasticIP"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/iPAddress",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/iPAddress:IPAddress": "IPAddress"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/instancePool",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/instancePool:InstancePool": "InstancePool"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/nIC",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/nIC:NIC": "NIC"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/nLB",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/nLB:NLB": "NLB"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/nLBService",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/nLBService:NLBService": "NLBService"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/network",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/network:Network": "Network"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/privateNetwork",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/privateNetwork:PrivateNetwork": "PrivateNetwork"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/sKSCluster",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/sKSCluster:SKSCluster": "SKSCluster"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/sKSNodePool",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/sKSNodePool:SKSNodePool": "SKSNodePool"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/sSHKey",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/sSHKey:SSHKey": "SSHKey"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/sSHKeyPair",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/sSHKeyPair:SSHKeyPair": "SSHKeyPair"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/secondaryIPAddress",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/secondaryIPAddress:SecondaryIPAddress": "SecondaryIPAddress"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/securityGroup",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/securityGroup:SecurityGroup": "SecurityGroup"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/securityGroupRule",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/securityGroupRule:SecurityGroupRule": "SecurityGroupRule"
  }
 },
 {
  "pkg": "exoscale",
  "mod": "index/securityGroupRules",
  "fqn": "pulumi_exoscale",
  "classes": {
   "exoscale:index/securityGroupRules:SecurityGroupRules": "SecurityGroupRules"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "exoscale",
  "token": "pulumi:providers:exoscale",
  "fqn": "pulumi_exoscale",
  "class": "Provider"
 }
]
"""
)
