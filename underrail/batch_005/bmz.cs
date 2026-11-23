using System;
using System.IO;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;

// Token: 0x02000163 RID: 355
public class bmz : eve
{
	// Token: 0x060008EC RID: 2284 RVA: 0x00025290 File Offset: 0x00023490
	public string yz()
	{
		if (!string.IsNullOrEmpty(this.c))
		{
			return this.c;
		}
		return "English";
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x000252B0 File Offset: 0x000234B0
	public void y0(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060008EE RID: 2286 RVA: 0x000252BC File Offset: 0x000234BC
	public string y1()
	{
		if (!string.IsNullOrEmpty(this.d))
		{
			return this.d;
		}
		return "Dialogs";
	}

	// Token: 0x060008EF RID: 2287 RVA: 0x000252DC File Offset: 0x000234DC
	public void y2(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x000252E8 File Offset: 0x000234E8
	public azm y3(string A_0)
	{
		czh.a(A_0, "dialogName");
		azm result = null;
		string text = Path.Combine(this.y1(), A_0) + ".udlg";
		if (File.Exists(text))
		{
			try
			{
				return eoq.DeserializeFromBinaryFile<azm>(text, dds.a(), true);
			}
			catch (Exception ex)
			{
				string str = "Error occured while loading DialogModel. Error: " + ex.ToString();
				if (this.e != null && this.e.n8() && this.e.n9(LogSeverity.Error, 115))
				{
					this.e.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str);
				}
				return result;
			}
		}
		string str2 = "Error occured while loading DialogModel. Dialog with name " + A_0 + " does not exist in " + this.y1();
		if (this.e != null && this.e.n8() && this.e.n9(LogSeverity.Error, 115))
		{
			this.e.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str2);
		}
		return result;
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00025408 File Offset: 0x00023608
	public void y4(azm A_0)
	{
		czh.a(A_0, "dialogModel");
		if (!Directory.Exists(this.y1()) && !string.IsNullOrEmpty(this.y1()))
		{
			Directory.CreateDirectory(this.y1());
		}
		string filePath = Path.Combine(this.y1(), A_0.e()) + ".udlg";
		try
		{
			eoq.SerializeToBinaryFile<azm>(filePath, A_0, dds.a(), eh9.c, true);
		}
		catch (Exception ex)
		{
			if (this.e != null && this.e.n8() && this.e.n9(LogSeverity.Error, 115))
			{
				this.e.n7(LogSeverity.Error, 115, "[Dialog Manager] Error occured while saving Dialog model to file system. Error: " + ex.ToString());
			}
		}
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x000254E4 File Offset: 0x000236E4
	public epf y5(azm A_0, bq8 A_1, bq8 A_2)
	{
		czh.a(A_0, "model");
		czh.a(A_1, "context");
		return new eqn(A_0, this, A_1, A_2 ?? new PropertyCollection());
	}

	// Token: 0x040005CA RID: 1482
	private const string a = "Dialogs";

	// Token: 0x040005CB RID: 1483
	private const string b = "English";

	// Token: 0x040005CC RID: 1484
	private string c = "English";

	// Token: 0x040005CD RID: 1485
	private string d = "Dialogs";

	// Token: 0x040005CE RID: 1486
	private cvq e = dr3.e();
}
