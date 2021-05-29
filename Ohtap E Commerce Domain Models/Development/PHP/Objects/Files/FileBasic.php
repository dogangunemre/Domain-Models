<?php
namespace Ohtap\ECommerce\DomainModels\Objects\Files;



class FileBasic extends  PathTypes implements IFileData
{   public $MIMEType;
    public $PathType;//PathType enum sınıfı tipinde
    public $Path;
    public $Size;
    public $Details;
    public $Description;
    public $State;
    public $OrderNo;
    public $ID;

}