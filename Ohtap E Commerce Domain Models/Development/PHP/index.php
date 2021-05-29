<?php
require 'vendor/autoload.php';

use Ohtap\ECommerce\DomainModels\Core\Communication\Message;
use Ohtap\ECommerce\DomainModels\Core\Communication\MessageList;
use Ohtap\ECommerce\DomainModels\Core\System\Lista;
use Ohtap\ECommerce\DomainModels\Objects\Addresses\AddressBasic;
use Ohtap\ECommerce\DomainModels\Objects\Addresses\AddressList;

$add = new AddressBasic();
echo $add->Name = "Ohtap";

$list = new AddressList();
$list = new Lista();