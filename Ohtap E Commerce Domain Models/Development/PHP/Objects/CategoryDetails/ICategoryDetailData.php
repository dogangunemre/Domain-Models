<?php

namespace Ohtap\ECommerce\DomainModels\Objects\CategoryDetails;
use Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ICategoryDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{


}