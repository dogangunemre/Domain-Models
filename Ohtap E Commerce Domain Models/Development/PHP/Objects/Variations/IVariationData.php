<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Variations;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IVariationData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
