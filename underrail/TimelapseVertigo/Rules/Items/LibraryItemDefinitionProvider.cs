using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Core.Logging;

namespace TimelapseVertigo.Rules.Items
{
	// Token: 0x0200222D RID: 8749
	[eiz("LIDP")]
	[Serializable]
	public sealed class LibraryItemDefinitionProvider<T> : TypedObjectReference<T>, bit, a67, ISerializable where T : bk3, new()
	{
		// Token: 0x0600CAFC RID: 51964 RVA: 0x0047DC80 File Offset: 0x0047BE80
		private LibraryItemDefinitionProvider(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
			if (ell.a() != 0)
			{
				this.a = A_0.GetString("LIDP:P");
				return;
			}
			if (base.GetType() == typeof(LibraryItemDefinitionProvider<T>))
			{
				this.a = A_0.GetString("_Path");
				return;
			}
			this.a = A_0.GetString("LibraryItemDefinitionProvider`1+_Path");
		}

		// Token: 0x0600CAFD RID: 51965 RVA: 0x0047DCF0 File Offset: 0x0047BEF0
		public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			base.GetObjectData(info, ctx);
			info.AddValue("LIDP:P", this.a);
		}

		// Token: 0x0600CAFE RID: 51966 RVA: 0x0047DD0C File Offset: 0x0047BF0C
		public bk3 wl()
		{
			return base.ao();
		}

		// Token: 0x0600CAFF RID: 51967 RVA: 0x0047DD1C File Offset: 0x0047BF1C
		public LibraryItemDefinitionProvider(string A_0)
		{
			czh.a(A_0, "path");
			this.a = A_0;
		}

		// Token: 0x0600CB00 RID: 51968 RVA: 0x0047DD38 File Offset: 0x0047BF38
		public bit wm()
		{
			return new LibraryItemDefinitionProvider<T>(this.a);
		}

		// Token: 0x0600CB01 RID: 51969 RVA: 0x0047DD48 File Offset: 0x0047BF48
		public override string ToString()
		{
			return string.Format("Type: {0}; Path: {1}", typeof(T).Name, this.a);
		}

		// Token: 0x0600CB02 RID: 51970 RVA: 0x0047DD6C File Offset: 0x0047BF6C
		protected override T h4()
		{
			T itemDefinition = ez2.GetItemDefinition<T>(this.a, true);
			if (itemDefinition == null)
			{
				dux.b(LogSeverity.Error, "Library item definition provider failed for item '{0}'. Returning a default instance.", new object[]
				{
					this.a
				});
				return ez2.GetDefaultItemDefinition<T>();
			}
			return itemDefinition;
		}

		// Token: 0x04004B0F RID: 19215
		private string a;
	}
}
