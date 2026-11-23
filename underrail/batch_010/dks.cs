using System;

// Token: 0x0200011C RID: 284
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class dks : Attribute
{
	// Token: 0x060006D6 RID: 1750 RVA: 0x0001C600 File Offset: 0x0001A800
	public string b()
	{
		return this.a;
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x0001C608 File Offset: 0x0001A808
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x0001C614 File Offset: 0x0001A814
	public Guid a()
	{
		return this.b;
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x0001C61C File Offset: 0x0001A81C
	public void a(Guid A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x0001C628 File Offset: 0x0001A828
	public bool c()
	{
		return this.c;
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x0001C630 File Offset: 0x0001A830
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x0001C63C File Offset: 0x0001A83C
	public dks(string A_0)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			throw new ArgumentException("Argument cannot be null or empty", "name");
		}
		this.a = A_0;
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x0001C670 File Offset: 0x0001A870
	public dks(string A_0, bool A_1)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			throw new ArgumentException("Argument cannot be null or empty", "name");
		}
		this.a = A_0;
		this.c = A_1;
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x0001C6A8 File Offset: 0x0001A8A8
	public dks(Guid A_0)
	{
		if (A_0 == Guid.Empty)
		{
			throw new ArgumentException("Argument cannot be empty.", "id");
		}
		this.b = A_0;
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
	public dks(Guid A_0, bool A_1)
	{
		if (A_0 == Guid.Empty)
		{
			throw new ArgumentException("Argument cannot be empty.", "id");
		}
		this.b = A_0;
		this.c = A_1;
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x0001C720 File Offset: 0x0001A920
	public dks(Guid A_0, string A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x0001C740 File Offset: 0x0001A940
	public dks(Guid A_0, string A_1, bool A_2)
	{
		this.b = A_0;
		this.a = A_1;
		this.c = A_2;
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x0001C764 File Offset: 0x0001A964
	public override object get_TypeId()
	{
		return dks.d;
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x0001C770 File Offset: 0x0001A970
	public override string ToString()
	{
		string text = (this.b() != null) ? this.b() : "Unnamed";
		return string.Concat(new string[]
		{
			"[Id=",
			this.a().ToString(),
			", Name=",
			text,
			", Critical=",
			this.c.ToString(),
			"]"
		});
	}

	// Token: 0x0400052E RID: 1326
	private string a;

	// Token: 0x0400052F RID: 1327
	private Guid b;

	// Token: 0x04000530 RID: 1328
	private bool c = true;

	// Token: 0x04000531 RID: 1329
	private static readonly Guid d = new Guid("4427E924-34E5-4044-9DEE-29F759537692");
}
