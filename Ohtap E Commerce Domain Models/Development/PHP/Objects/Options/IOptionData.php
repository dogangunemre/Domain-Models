<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Options;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IOptionData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
