<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Labels;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface ILabelData extends CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
