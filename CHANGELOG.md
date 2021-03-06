# Change Log

## [0.12.3](https://github.com/bunq/sdk_csharp/tree/0.12.3) (2017-11-15)
[Full Changelog](https://github.com/bunq/sdk_csharp/compare/0.12.2...0.12.3)

**Implemented enhancements:**

- Callback models for holding callback data  [\#41](https://github.com/bunq/sdk_csharp/issues/41)

**Fixed bugs:**

- ScheduledPayment causes decode error due to Typo [\#45](https://github.com/bunq/sdk_csharp/issues/45)

**Merged pull requests:**

- Feature/callback models bunq/sdk csharp\#41 [\#44](https://github.com/bunq/sdk_csharp/pull/44) ([OGKevin](https://github.com/OGKevin))

## [0.12.2](https://github.com/bunq/sdk_csharp/tree/0.12.2) (2017-11-08)
[Full Changelog](https://github.com/bunq/sdk_csharp/compare/0.12.0...0.12.2)

**Implemented enhancements:**

- Missing CARD GENERATED CVC2 endpoint [\#35](https://github.com/bunq/sdk_csharp/issues/35)
- More flexibility for sessionContext handling [\#28](https://github.com/bunq/sdk_csharp/issues/28)
- Feature/is session active\#33 [\#34](https://github.com/bunq/sdk_csharp/pull/34) ([OGKevin](https://github.com/OGKevin))
- Added cvc\_endpoint. \#35 [\#36](https://github.com/bunq/sdk_csharp/pull/36) ([OGKevin](https://github.com/OGKevin))

**Fixed bugs:**

- DraftPayment object field causes converter error [\#37](https://github.com/bunq/sdk_csharp/issues/37)

**Closed issues:**

- Add missing fields for cvc endpoint [\#38](https://github.com/bunq/sdk_csharp/issues/38)
- More flexibility for sessionContext handling [\#33](https://github.com/bunq/sdk_csharp/issues/33)

**Merged pull requests:**

- Bump C\# language version [\#29](https://github.com/bunq/sdk_csharp/pull/29) ([mikhail-denisenko](https://github.com/mikhail-denisenko))
- Feature/fix draft payment object \#37 [\#40](https://github.com/bunq/sdk_csharp/pull/40) ([OGKevin](https://github.com/OGKevin))
- Feature/add missing cvc fields \#38 [\#39](https://github.com/bunq/sdk_csharp/pull/39) ([OGKevin](https://github.com/OGKevin))

## [0.12.0](https://github.com/bunq/sdk_csharp/tree/0.12.0) (2017-10-11)
[Full Changelog](https://github.com/bunq/sdk_csharp/compare/0.11.0...0.12.0)

**Implemented enhancements:**

- Better error handling  [\#22](https://github.com/bunq/sdk_csharp/issues/22)
- Add Pagination [\#17](https://github.com/bunq/sdk_csharp/issues/17)
- Feature/exception handler [\#23](https://github.com/bunq/sdk_csharp/pull/23) ([OGKevin](https://github.com/OGKevin))
- Marked all files in generated dir as generated code. [\#21](https://github.com/bunq/sdk_csharp/pull/21) ([OGKevin](https://github.com/OGKevin))

**Closed issues:**

- Improve Model Namespaces [\#24](https://github.com/bunq/sdk_csharp/issues/24)

**Merged pull requests:**

- cleanup after 24-improve-namespaces [\#27](https://github.com/bunq/sdk_csharp/pull/27) ([dnl-blkv](https://github.com/dnl-blkv))
- Improve namespaces; cleanup \[\#24\] [\#25](https://github.com/bunq/sdk_csharp/pull/25) ([dnl-blkv](https://github.com/dnl-blkv))

## [0.11.0](https://github.com/bunq/sdk_csharp/tree/0.11.0) (2017-09-06)
[Full Changelog](https://github.com/bunq/sdk_csharp/compare/0.10.0...0.11.0)

**Implemented enhancements:**

- Ignore generated code for reviews [\#19](https://github.com/bunq/sdk_csharp/issues/19)
- Add proxy support  [\#15](https://github.com/bunq/sdk_csharp/issues/15)
- Response is missing response headers and pagination [\#5](https://github.com/bunq/sdk_csharp/issues/5)
- Added git attributes. [\#20](https://github.com/bunq/sdk_csharp/pull/20) ([OGKevin](https://github.com/OGKevin))
- Add pagination; add missing fields and objects \[\#17\] [\#18](https://github.com/bunq/sdk_csharp/pull/18) ([dnl-blkv](https://github.com/dnl-blkv))

## [0.10.0](https://github.com/bunq/sdk_csharp/tree/0.10.0) (2017-08-23)
[Full Changelog](https://github.com/bunq/sdk_csharp/compare/0.9.2...0.10.0)

**Implemented enhancements:**

- Allow saving context to JSON and restoring from it [\#13](https://github.com/bunq/sdk_csharp/issues/13)
- Bunq SDK needs two minor refactors [\#11](https://github.com/bunq/sdk_csharp/issues/11)
- add proxy support, make httpClient instance variable \[\#15\] [\#16](https://github.com/bunq/sdk_csharp/pull/16) ([dnl-blkv](https://github.com/dnl-blkv))
- add methods to serialize and de-serialize ApiContext, fix Card \[\#13\] [\#14](https://github.com/bunq/sdk_csharp/pull/14) ([dnl-blkv](https://github.com/dnl-blkv))

**Fixed bugs:**

- ArgumentException in SessionServerConverter [\#7](https://github.com/bunq/sdk_csharp/issues/7)

**Merged pull requests:**

- cleanup C\# SDK \[\#11\] [\#12](https://github.com/bunq/sdk_csharp/pull/12) ([dnl-blkv](https://github.com/dnl-blkv))
- Merge hotfixed master back to develop [\#10](https://github.com/bunq/sdk_csharp/pull/10) ([dnl-blkv](https://github.com/dnl-blkv))

## [0.9.2](https://github.com/bunq/sdk_csharp/tree/0.9.2) (2017-08-18)
[Full Changelog](https://github.com/bunq/sdk_csharp/compare/0.9.1...0.9.2)

**Implemented enhancements:**

- \#5 Introduce BunqResponse [\#6](https://github.com/bunq/sdk_csharp/pull/6) ([dnl-blkv](https://github.com/dnl-blkv))

**Fixed bugs:**

- Fix SessionServerConverter, bump up to 0.9.2.0-beta \[\#7\] [\#8](https://github.com/bunq/sdk_csharp/pull/8) ([dnl-blkv](https://github.com/dnl-blkv))

## [0.9.1](https://github.com/bunq/sdk_csharp/tree/0.9.1) (2017-08-07)
**Implemented enhancements:**

- Complete project info [\#3](https://github.com/bunq/sdk_csharp/issues/3)
- Added readme for tests  [\#2](https://github.com/bunq/sdk_csharp/pull/2) ([OGKevin](https://github.com/OGKevin))
- Add first wave unit-tests [\#1](https://github.com/bunq/sdk_csharp/pull/1) ([OGKevin](https://github.com/OGKevin))

**Merged pull requests:**

- Fix project info [\#4](https://github.com/bunq/sdk_csharp/pull/4) ([dnl-blkv](https://github.com/dnl-blkv))



\* *This Change Log was automatically generated by [github_changelog_generator](https://github.com/skywinder/Github-Changelog-Generator)*