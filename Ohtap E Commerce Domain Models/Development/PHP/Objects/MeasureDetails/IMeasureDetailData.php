<?php

namespace Ohtap\ECommerce\DomainModels\Objects\MeasureDetails;

use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IMeasureDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
