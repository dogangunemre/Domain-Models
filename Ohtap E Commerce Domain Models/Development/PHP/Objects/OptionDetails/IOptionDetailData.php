<?php

namespace Ohtap\ECommerce\DomainModels\Objects\OptionDetails;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IOptionDetailData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
