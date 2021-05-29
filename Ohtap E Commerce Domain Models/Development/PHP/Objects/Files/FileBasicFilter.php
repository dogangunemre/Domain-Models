<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Files;

class FileBasicFilter  implements IFileBasicFilter
{
    public $MIMEType;
    public $PathType;//PathType enum sınıfı tipinde
    public $Path;
    public $Size;
    public $Title;
    public $Name;
    public $Description;
    public $State;
    public $OrderNo;
    public $ID;

}

