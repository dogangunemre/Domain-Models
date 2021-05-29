<?php

namespace Ohtap\ECommerce\DomainModels\Objects\VariationDetails;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IVariationDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
