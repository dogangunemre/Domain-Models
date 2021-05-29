<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Banks;
use Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IBankData extends IBankPhone,IBankFax,IBankEmail,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{


}