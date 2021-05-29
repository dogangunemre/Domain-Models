<?php

namespace Ohtap\ECommerce\DomainModels\Objects\Files;


use  Ohtap\ECommerce\DomainModels\Core\Object as  CoreObjects ;


interface IFileData extends IFilePath,IFilePathType,IFileMIMEType,IFileSize,CoreObjects\IObjectID, CoreObjects\IObjectCode,
    CoreObjects\IObjectDescription, CoreObjects\IObjectName, CoreObjects\IObjectOrder, CoreObjects\IObjectState, CoreObjects\IObjectTitle
{

}
