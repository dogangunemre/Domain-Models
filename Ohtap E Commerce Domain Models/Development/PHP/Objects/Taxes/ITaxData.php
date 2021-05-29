<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Taxs;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ITaxData extends ITaxValue,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
