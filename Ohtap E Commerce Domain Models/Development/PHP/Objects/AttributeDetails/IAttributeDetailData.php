<?php


namespace Ohtap\ECommerce\DomainModels\Objects\AttributeDetails;

use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IAttributeDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}