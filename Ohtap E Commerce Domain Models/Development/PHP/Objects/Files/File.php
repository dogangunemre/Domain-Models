<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Files;

class File  implements IFile
{

    public $MIMEType;
    public $PathType;//PathType enum sınıfı tipinde
    public $Path;
    public $Size;
    public $Details;
    public $Description;
    public $State;
    public $OrderNo;
    public $ID;
}