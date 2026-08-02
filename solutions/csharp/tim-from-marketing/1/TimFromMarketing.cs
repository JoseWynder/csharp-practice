static class Badge
{
    public static string Print(int? id, string name, string? department) {
        string badgeDepartment = (department ?? "Owner").ToUpper();
        return id == null 
            ? $"{name} - {badgeDepartment}" 
            : $"[{id}] - {name} - {badgeDepartment}";
    } 
}
