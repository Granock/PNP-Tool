using PNP.Tool.Models;

namespace PNP.Tool.DTOs.Base {
    public static class BaseExtension {
        public static TDTO ToBaseDTO<TEntry,TDTO>(this TEntry entry) where TEntry : BaseEntity 
                                                                     where TDTO : BaseDTO, new() {
            return new() { GUID = entry.GUID };
        }
    }
}
